using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour
{
    public Transform offset;
    public GameObject target;
    
    public void Move(Transform moveLocation)
    {
        //target.transform.position = target.transform.position - offset.transform.position;
        target.transform.position = moveLocation.transform.position;
    }
}
