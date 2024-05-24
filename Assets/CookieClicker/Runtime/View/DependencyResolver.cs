﻿using System;
using UnityEngine;

public class DependencyResolver : MonoBehaviour
{
    private void Awake()
    {
        CookieClicker cookieClicker = CookieClicker.CreateEmpty();
        var cookiesButtonAndCounter = FindObjectOfType<CookiesButtonAndCounter>();
        var purchaseUpgradeButton = FindObjectOfType<PurchaseUpgradeButton>();
        var purchaseUpgradePresenter = new PurchaseUpgrade(cookieClicker, cookiesButtonAndCounter);
        purchaseUpgradeButton.Configure(purchaseUpgradePresenter);
    }
}