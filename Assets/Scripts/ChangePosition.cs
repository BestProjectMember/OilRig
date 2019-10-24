using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour
{
    public Transform Target;
    //public Transform destination;
    
    public void Move(Transform destination)
    {
        Target.transform.position = destination.transform.position;
    }
}
