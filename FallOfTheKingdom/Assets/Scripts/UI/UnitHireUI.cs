using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitHireUI : MonoBehaviour
{
    [SerializeField] Image unitImage;
    [SerializeField] Text unitCost;
    [SerializeField] Text unitName;
    [SerializeField] Text unitAmount;

    public UnitHireMenu menu;

    GoblinTypes goblinType;
    AppeaserTypes appeaserType;

    public void SetUI(UnitResources u)
    {
        unitImage.sprite = u.UnitSprite;
        unitCost.text = u.Cost.ToString() + " GOLD";
        unitName.text = u.UnitName;
        if (u is GoblinResources)
        {
            Debug.Log("Hire");
            goblinType = ((GoblinResources)u).Type;
        }
        else if(u is AppeaserResources)
        {
            appeaserType = ((AppeaserResources)u).Type;
        }
        unitAmount.text = menu.hirer.GetUnitNumber(u).ToString();
    }

    public void HireUnit()
    {
        Debug.Log(goblinType);
        if (goblinType != GoblinTypes.None)
        {
            menu.hirer.HireGoblin((int)goblinType);
        }
        else if (appeaserType != AppeaserTypes.None)
        {
            menu.hirer.HireAppeaser((int)appeaserType);
        }
    }

    //update unit amount
}
