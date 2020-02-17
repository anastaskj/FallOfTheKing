using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinResources : UnitResources
{
    //resources for gathering
    [SerializeField] float anger;
    [SerializeField] float goldGatherValue;

    public float GoldGatherValue { get { return goldGatherValue; } }
}
