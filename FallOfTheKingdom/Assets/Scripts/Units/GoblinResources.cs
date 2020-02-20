using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinResources : UnitResources
{
    //resources for gathering
    [SerializeField] float anger;
    [SerializeField] float goldGatherValue;
    [SerializeField] GoblinTypes type;
    AppeaserTypes prefferedAppeaser;

    public float GoldGatherValue { get { return goldGatherValue; } }
    public AppeaserTypes PrefferedAppeaser { get { return prefferedAppeaser; } set { prefferedAppeaser = value; } }
    public GoblinTypes Type { get { return type; } }
    public float Anger {  get { return anger; } set { anger = value; } }
}
