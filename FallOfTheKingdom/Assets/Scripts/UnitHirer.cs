using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitHirer : MonoBehaviour
{
    [SerializeField] GoblinController[] goblinPrefabs;
    [SerializeField] Workcamp workCamp;

    [SerializeField] GameObject workstation; //temp

    public void HireGoblin(int index)
    {
        GoblinController goblin = goblinPrefabs[index];
        if (goblin.CanHire(workCamp.CampGold)) //if you have enough money to hire a goblin
        {
            workCamp.AddGoblinToWorkcamp(goblin);
            Instantiate(goblin.gameObject, workstation.transform);
        }
    }
}
