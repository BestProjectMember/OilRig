using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallUngrabOnEnter : MonoBehaviour
{
    public ActivateUngrab ungrabber;
   
    private void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Wall chain")
        {
            ungrabber.ungrab();
        }
    }
}
