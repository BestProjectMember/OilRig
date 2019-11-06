using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour
{
    public Transform offset;
    public GameObject target;
    public Transform moveLocation;
    public bool move = true;


    public void Move(Transform moveLocation)
    {
        target.transform.position = moveLocation.transform.position;
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Move(moveLocation);
        }
    }
}
