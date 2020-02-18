using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitResources : MonoBehaviour
{
    //resources for gathering
    [SerializeField] int cost;
    //general
    [SerializeField] string unitName;
    [SerializeField] Sprite unitSprite;
    //resources for fighting
    [SerializeField] int health;
    [SerializeField] float damage;
    [SerializeField] float attackRate;


    public int Cost { get { return cost; } }
    public string UnitName { get { return unitName; } }
    public Sprite UnitSprite { get { return unitSprite; } }
}
