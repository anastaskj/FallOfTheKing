using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitController : MonoBehaviour
{
    UnitResources unitRes;

    public bool CanHire(float priceComparison)
    {
        if (unitRes.Cost > priceComparison)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
