using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Workcamp : MonoBehaviour
{
    [SerializeField] float campGold;
    [SerializeField] float startGainTimer;
    float gainTimer;
    List<GoblinController> goblinWorkforce;
    List<AppeaserController> appeaserWorkforce;

    public float CampGold { get { return campGold; } }
    public UnityEvent OnGoldChanged = new UnityEvent();
    public UnityEvent OnUnitHired = new UnityEvent();

    private void Awake()
    {
        //change to save and load system
        goblinWorkforce = new List<GoblinController>(); 
        appeaserWorkforce = new List<AppeaserController>();
    }

    private void Update()
    {
        if (goblinWorkforce.Count > 0)
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
        campGold -= unit.GetResources().Cost;

        //invoke event
    }


    void GainGoldFromGoblins()
    {
        float amount = 0;
        foreach (GoblinController goblin in goblinWorkforce)
        {
            amount += goblin.GatherGold();
        }

        GoldChange(amount);
    }

    public void GainGoldFromPlayer(float amount)
    {
        GoldChange(amount);
    }


    void GoldChange(float amount)
    {
        campGold += amount;
        OnGoldChanged.Invoke();
        OnUnitHired.Invoke();
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
