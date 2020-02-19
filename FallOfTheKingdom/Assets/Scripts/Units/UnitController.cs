using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitController : MonoBehaviour
{
    [SerializeField]
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

    public virtual UnitResources GetResources()
    {
        return unitRes;
    }
}
