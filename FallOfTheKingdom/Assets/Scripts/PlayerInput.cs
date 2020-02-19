using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] Workcamp camp;
    [SerializeField] float baseGoldPerClick;

    //add click cooldown

    void TortureGoblin(GoblinController goblin)
    {
        float goldGained = baseGoldPerClick * 1; //replace 1 with a variable for a multiplier 
        camp.GainGoldFromPlayer(goldGained);

        goblin.OnInteraction();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) //pc only for now
        {
            HandleInput();
        }
    }

    void HandleInput()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.one);
        if (hit.collider != null)
        {
            if (hit.collider.gameObject.tag == "Goblin")
            {
                TortureGoblin(hit.collider.gameObject.GetComponent<GoblinController>());
            }
        }
    }
}
