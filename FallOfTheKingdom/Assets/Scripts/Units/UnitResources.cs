using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitResources : MonoBehaviour
{
    //resources for gathering
    [SerializeField] int cost;
    //resources for fighting
    [SerializeField] int health;
    [SerializeField] float damage;
    [SerializeField] float attackRate;

    public int Cost { get { return cost; } }
}
