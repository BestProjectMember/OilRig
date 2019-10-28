using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour
{
    public GameObject target;

    public void Move(GameObject moveLocation)
    {
        target.transform.position = moveLocation.transform.position;
    }
}
