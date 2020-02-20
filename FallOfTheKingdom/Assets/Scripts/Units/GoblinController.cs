using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinController : UnitController
{
    [SerializeField] GoblinResources goblinRes;
    [SerializeField] GoblinView goblinView;
    [SerializeField] float gatherMultiplier;
    //linked appeaser


    //gather gold
    public float GatherGold()
    {
        return goblinRes.GoldGatherValue * gatherMultiplier;
    }

    //resource link
    public override UnitResources GetResources()
    {
        return goblinRes;
    }

    public void OnInteraction()
    {
        goblinView.InteractionAnimation();
    }

    void GainAnger(float value)
    {
        goblinRes.Anger += value;
    }
}
