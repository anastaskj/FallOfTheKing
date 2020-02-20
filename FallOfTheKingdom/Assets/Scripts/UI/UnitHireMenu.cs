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
        FillList(hirer.GoblinPrefabs);
    }

    public void FillListAppeasers()
    {
        FillList(hirer.AppeaserPrefabs);
    }

    void FillList(UnitController[] units)
    {
        for (int i = 0; i < listContent.childCount; i++)
        {
            Destroy(listContent.GetChild(i).gameObject);
        }
        for (int i = 0; i < units.Length; i++)
        {
            UnitHireUI item = Instantiate(hireUIPrefab);
            item.menu = this;
            item.transform.SetParent(listContent, false);
            item.SetUI(units[i].GetResources());
        }
    }

}
