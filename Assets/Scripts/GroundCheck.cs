using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public LayerMask mask;
    float range = 20f;
    [HideInInspector]
    public string floorType;

    public void Cast()
    {
        if(gameObject.active == true)
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, -transform.forward, out hit, range, mask))
            {
                floorType = hit.transform.tag;
                print(floorType);
            }
        }

    }

    public void CastPhysical()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, -transform.up, out hit, range, mask))
        {
            floorType = hit.transform.tag;
            print(floorType);
        }
    }

    private void OnDisable()
    {
        floorType = "";
    }
}
