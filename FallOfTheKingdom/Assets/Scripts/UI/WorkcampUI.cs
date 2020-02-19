using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorkcampUI : MonoBehaviour
{
    [SerializeField] Workcamp workcamp;
    [SerializeField] Text goldText;
   //add details about the various goblins, etc

    public void UpdateGold()
    {
        goldText.text = workcamp.CampGold.ToString() + " Gold";
    }

    private void OnEnable()
    {
        UpdateGold();
        workcamp.OnGoldChanged.AddListener(UpdateGold);
    }

    private void OnDisable()
    {
        workcamp.OnGoldChanged.RemoveListener(UpdateGold);
    }
}
