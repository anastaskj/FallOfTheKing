using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitHireMenu : MonoBehaviour
{
    [SerializeField] RectTransform listContent;
    [SerializeField] UnitHireUI hireUIPrefab;
    public UnitHirer hirer;

    private void Start()
    {
        FillListGoblins();
    }
    public void FillListGoblins()
    {
        for (int i = 0; i < listContent.childCount; i++)
        {
            Destroy(listContent.GetChild(i).gameObject);
        }

        for (int i = 0; i < hirer.GoblinPrefabs.Length; i++)
        {
            UnitHireUI item = Instantiate(hireUIPrefab);
            item.menu = this;
            item.transform.SetParent(listContent, false);
            item.SetUI(hirer.GoblinPrefabs[i].GetResources());
        }
    }

    public void FillListAppeasers()
    {
        for (int i = 0; i < listContent.childCount; i++)
        {
            Destroy(listContent.GetChild(i).gameObject);
        }

        for (int i = 0; i < hirer.AppeaserPrefabs.Length; i++)
        {
            UnitHireUI item = Instantiate(hireUIPrefab);
            item.menu = this;
            item.transform.SetParent(listContent, false);
            item.SetUI(hirer.AppeaserPrefabs[i].GetResources());

        }
    }

    
}
