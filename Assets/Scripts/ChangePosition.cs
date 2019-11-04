using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour
{
    public void Move(GameObject moveLocation)
    {
        gameObject.transform.position = moveLocation.transform.position;
    }
}
