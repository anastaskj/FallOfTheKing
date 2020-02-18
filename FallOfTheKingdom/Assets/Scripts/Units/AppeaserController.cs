using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppeaserController : UnitController
{
    [SerializeField] AppeaserResources appeaserRes;

    public void SetAppeaser(GoblinController goblin)
    {

    }

    //resource link
    public override UnitResources GetResources()
    {
        return appeaserRes;
    }
}
