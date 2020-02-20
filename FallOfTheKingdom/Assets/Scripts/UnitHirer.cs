using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnitHirer : MonoBehaviour
{
    [SerializeField] GoblinController[] goblinPrefabs;
    [SerializeField] AppeaserController[] appeaserPrefabs;

    [SerializeField] GameObject[] workstations; //temp

    [SerializeField] public Workcamp workCamp;

    public GoblinController[] GoblinPrefabs { get { return goblinPrefabs; } }
    public AppeaserController[] AppeaserPrefabs { get { return appeaserPrefabs; } }

    public void HireGoblin(int index)
    {
        GoblinController goblin = goblinPrefabs[index-1]; //-1 because None is the first possibility
        if (goblin.CanHire(workCamp.CampGold)) //if you have enough money to hire a goblin
        {
            workCamp.AddUnitToWorkcamp(goblin);

            Transform yeahtemp = null;
            switch (((GoblinResources)goblin.GetResources()).Type)
            {
                case GoblinTypes.None:
                    break;
                case GoblinTypes.Miner:
                    yeahtemp = workstations[0].transform;
                    break;
                case GoblinTypes.Builder:
                    yeahtemp = workstations[1].transform;
                    break;
                case GoblinTypes.Meathead:
                    yeahtemp = workstations[2].transform;
                    break;
                default:
                    break;
            }

            Instantiate(goblin.gameObject, yeahtemp);
            //Instantiate(goblin.gameObject, workstation.transform);

            workCamp.OnGoldChanged.Invoke();
        }
        else
        {
            //inform UI with event call
        }
    }
    public void HireAppeaser(int index)
    {
        AppeaserController appeaser = appeaserPrefabs[index-1]; //-1 because None is the first possibility
        if (appeaser.CanHire(workCamp.CampGold))//if you have enough money to hire an appeaser
        {
            workCamp.AddUnitToWorkcamp(appeaser);
            workCamp.OnGoldChanged.Invoke();

            //add to bench
        }
        else
        {
            //inform UI with event call
        }
    }

    public int GetUnitNumber(UnitResources unit)
    {
        int number;
        if (unit is GoblinResources)
        {
            number = workCamp.GetNumberOfGoblinsByType(((GoblinResources)unit).Type);
        }
        else
        {
            number = workCamp.GetNumberOfAppeasersByType(((AppeaserResources)unit).Type);
        }
        return number;
    }

    public float GetCampGold()
    {
        return workCamp.CampGold;
    }
}
