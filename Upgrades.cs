using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades : MonoBehaviour { 

    Game game; 
    public GameObject Action01;
    public GameObject Action02;
    public GameObject Action03;
    public bool action01Activated;
    public bool action02Activated;
    public bool action03Activated;
    ResourcesManager resources;

    void Start()
    {
        game = Game.Instance;
        resources = ResourcesManager.Instance;
        ActionsDisabled();
    }

    void Update()
    {
        ActionsDisplay();
        
        if (game.myState == Game.States.GameStart)
        {
            if ((ResourcesManager.moneyTotal > 2) && (!action01Activated)) { Action01.SetActive(true); }
            if ((ResourcesManager.materialsTotal > 2) && (!action02Activated)) { Action02.SetActive(true); }
            if ((ResourcesManager.moneyTotal > 4) && (game.lifeTotal < 10) && (!action03Activated)) { Action03.SetActive(true); }
        }
    }

    public void ActionsDisplay()
    {
        if (ResourcesManager.moneyTotal < 3)
        {
            Action01.SetActive(false);
        }
        else if (ResourcesManager.materialsTotal < 3)
        {
            Action02.SetActive(false);
        }
        else if (ResourcesManager.moneyTotal < 5)
        {
            Action03.SetActive(false);
        }
    }

    public void ActionsDisabled()
    {
        Action01.SetActive(false);
        Action02.SetActive(false);
        Action03.SetActive(false);
        action01Activated = false;
        action02Activated = false;
        action03Activated = false;
    }
    public void SellMaterials()
    {
        resources.WoodChange(-3);
        resources.MoneyChange(1);
        Action02.SetActive(false);
        action02Activated = true;
    }

    public void BuyMaterials()
    {
        resources.WoodChange(1);
        resources.MoneyChange(-3);
        Action01.SetActive(false);
        action01Activated = true;
    }

    public void Doctor()
    {
        resources.MoneyChange(-5);
        game.lifeTotal++;
        Action03.SetActive(false);
        action03Activated = true;
    }
}
