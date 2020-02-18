using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinController : UnitController
{
    [SerializeField] GoblinResources goblinRes;
    float gatherMultiplier;
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

}
