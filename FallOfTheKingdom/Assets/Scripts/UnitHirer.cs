using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnitHirer : MonoBehaviour
{
    [SerializeField] GoblinController[] goblinPrefabs;
    [SerializeField] AppeaserController[] appeaserPrefabs;
    [SerializeField] Workcamp workCamp;

    [SerializeField] GameObject workstation; //temp

    public GoblinController[] GoblinPrefabs { get { return goblinPrefabs; } }
    public AppeaserController[] AppeaserPrefabs { get { return appeaserPrefabs; } }

    public void HireGoblin(int index)
    {
        GoblinController goblin = goblinPrefabs[index-1]; //-1 because None is the first possibility
        if (goblin.CanHire(workCamp.CampGold)) //if you have enough money to hire a goblin
        {
            Debug.Log("Hire2");
            workCamp.AddUnitToWorkcamp(goblin);
            Instantiate(goblin.gameObject, workstation.transform);
        }
        else
        {
            //inform UI with event call
        }
    }
    public void HireAppeaser(int index)
    {
        AppeaserController appeaser = appeaserPrefabs[index-1]; //-1 because None is the first possibility
        if (appeaser.CanHire(workCamp.CampGold))
        {
            workCamp.AddUnitToWorkcamp(appeaser);

            //add to bench
        }
        else
        {
            //inform UI with event call
        }
    }

    public int GetUnitNumber(UnitResources unit)
    {
        if (unit is GoblinResources)
        {
            return workCamp.GetNumberOfGoblinsByType(((GoblinResources)unit).Type);
        }
        else
        {
            return workCamp.GetNumberOfAppeasersByType(((AppeaserResources)unit).Type);
        }
    }
}
