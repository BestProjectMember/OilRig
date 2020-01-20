using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public LayerMask mask;
    float range = 20f;
    [HideInInspector]
    public string floorType;
    Vector3 s;

    private void Start()
    {
        s = new Vector3(0, 2, 0);
    }

    public void CastPhysical()
    {
        
        RaycastHit hit;
        if (Physics.Raycast(transform.position + s, -transform.up, out hit, range, mask))
        {
            floorType = hit.transform.tag;
        }
    }

    private void OnDisable()
    {
        floorType = "";
    }
}
