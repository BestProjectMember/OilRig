using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{
    public Transform[] joints;

    public float percentage;

    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.tag == "BentPipe")
        {
            print("HAHA");
            for (int i = 0; i < joints.Length; i++)
            {
                joints[i].localRotation = Quaternion.Euler(0, ((joints[i].localRotation.eulerAngles.y) - (joints[i].localRotation.eulerAngles.y / 100 * percentage)), 0);
            }
        }
    }
}
