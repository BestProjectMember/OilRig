using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{
    public Unbend unbend;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BentPipe")
        {
            unbend.UnbendAnim();
        }
    }
}
