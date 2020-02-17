using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workcamp : MonoBehaviour
{
    [SerializeField] float campGold;
    [SerializeField] float startGainTimer;
    float gainTimer;
    List<GoblinController> goblinWorkforce;

    public float CampGold { get { return CampGold; } }


    private void Awake()
    {
        goblinWorkforce = new List<GoblinController>();
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

    public void AddGoblinToWorkcamp(GoblinController goblin)
    {
        goblinWorkforce.Add(goblin);
    }

    void GainGoldFromGoblins()
    {
        foreach (GoblinController goblin in goblinWorkforce)
        {
            goblin.GatherGold();
        }
    }


}
