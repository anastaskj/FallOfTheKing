using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppeaserResources : UnitResources
{
    [SerializeField] float baseGoldMultiplierValue;
    [SerializeField] AppeaserTypes type;

    public AppeaserTypes Type { get { return type; } }
    public float BaseGoldMultiplierValue { get { return baseGoldMultiplierValue; } }
}
