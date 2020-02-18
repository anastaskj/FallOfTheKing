using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workcamp : MonoBehaviour
{
    [SerializeField] float campGold;
    [SerializeField] float startGainTimer;
    float gainTimer;
    List<GoblinController> goblinWorkforce;
    List<AppeaserController> appeaserWorkforce;
    public float CampGold { get { return CampGold; } }


    private void Awake()
    {
        goblinWorkforce = new List<GoblinController>(); //change to save and load system
        appeaserWorkforce = new List<AppeaserController>();
    }

    private void Update()
    {
        if (true) //change to some shit
        {
            gainTimer -= Time.deltaTime;
            if (gainTimer <= 0) //trigger
            {
                GainGoldFromGoblins();
                gainTimer = startGainTimer;
            }
        }
    }

    public void AddUnitToWorkcamp(UnitController unit)
    {
        if (unit is GoblinController)
        {
            goblinWorkforce.Add((GoblinController)unit);
        }
        else if(unit is AppeaserController)
        {
            appeaserWorkforce.Add((AppeaserController)unit);
        }
        
    }

    void GainGoldFromGoblins()
    {
        foreach (GoblinController goblin in goblinWorkforce)
        {
            goblin.GatherGold();
        }
        Debug.Log("GOLD GAINED");
    }

    public int GetNumberOfGoblinsByType(GoblinTypes type)
    {
        int count = 0;
        foreach (GoblinController goblin in goblinWorkforce)
        {
            if (((GoblinResources)goblin.GetResources()).Type == type)
            {
                count++;
            }
        }
        return count;
    }

    public int GetNumberOfAppeasersByType(AppeaserTypes type)
    {
        int count = 0;
        foreach (AppeaserController appeaser in appeaserWorkforce)
        {
            if (((AppeaserResources)appeaser.GetResources()).Type == type)
            {
                count++;
            }
        }
        return count;
    }

}
