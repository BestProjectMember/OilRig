using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    float range = 1f;
    [HideInInspector]
    public string floorType;

    public void Cast()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, -transform.up, out hit, range))
        {
            floorType = hit.transform.tag;
            print(floorType);
        }
    }
}
