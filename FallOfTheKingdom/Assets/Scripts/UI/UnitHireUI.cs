﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitHireUI : MonoBehaviour
{
    [SerializeField] Image unitImage;
    [SerializeField] Text unitCost;
    [SerializeField] Text unitName;
    [SerializeField] Text unitAmount;
    [SerializeField] Button button;

    public UnitHireMenu menu;

    UnitResources unit;
    GoblinTypes goblinType;
    AppeaserTypes appeaserType;

    public void SetUI(UnitResources u)
    {
        unitImage.sprite = u.UnitSprite;
        unitCost.text = u.Cost.ToString() + " GOLD";
        unitName.text = u.UnitName;
        unit = u;

        if (u is GoblinResources)
        {
            goblinType = ((GoblinResources)u).Type;
        }
        else if(u is AppeaserResources)
        {
            appeaserType = ((AppeaserResources)u).Type;
        }

        ChangeInteractable();
        UpdateUnitAmount();

        menu.hirer.workCamp.OnUnitHired.AddListener(ChangeInteractable);
    }

    public void UpdateUnitAmount()
    {
        unitAmount.text = menu.hirer.GetUnitNumber(unit).ToString();
    }

    public void ChangeInteractable()
    {
        if (menu.hirer.GetCampGold() >= unit.Cost)
        {
            button.interactable = true;
        }
        else
        {
            button.interactable = false;
        }
    }

    public void HireUnit()
    {
        if (goblinType != GoblinTypes.None)
        {
            menu.hirer.HireGoblin((int)goblinType);
        }
        else if (appeaserType != AppeaserTypes.None)
        {
            menu.hirer.HireAppeaser((int)appeaserType);
        }
        UpdateUnitAmount();

        menu.hirer.workCamp.OnUnitHired.Invoke();
    }
}
