using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour
{
    public GameObject target;

    public void Move(Transform moveLocation)
    {
        target.transform.position = moveLocation.transform.position;
    }
}
