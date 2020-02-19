using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitView : MonoBehaviour
{
    [SerializeField] Animator anim;
    UnitResources unitRes;
    //prefab for ingame UI

    public virtual void InteractionAnimation()
    {
        anim.SetTrigger("Interaction");
        Debug.Log("Interaction");
    }
}
