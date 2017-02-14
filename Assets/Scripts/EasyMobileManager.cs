﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyMobile;
using System;

public class EasyMobileManager : MonoBehaviour {

    static EasyMobileManager instance;
    public static EasyMobileManager Instance
    {
        get { return instance; }
    }

    private void Awake()
    {
        instance = this;
    }

    public static void ShowInterstitialAd()
    {
        instance.StartCoroutine(instance.CoShowBanner());
    }

	// Use this for initialization
	void Start () {

	}

    private IEnumerator CoShowBanner()
    {
        yield return new WaitUntil(() => 
        {
            return AdManager.IsInterstitialAdReady();
        });
        AdManager.ShowInterstitialAd();
    }



    // Update is called once per frame
    void Update () {
		
	}
}
