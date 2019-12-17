using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Hammer : MonoBehaviour
{
    public Transform[] joints;
    public UnityEvent onUnbend;
    public float percentage;

    private void Start()
    {
        if (onUnbend == null)
            onUnbend = new UnityEvent();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "BentPipe")
        {
            for (int i = 0; i < joints.Length; i++)
            {
                if(joints[i].localRotation.eulerAngles.y >= 2)
                    joints[i].localRotation = Quaternion.Euler(0, ((joints[i].localRotation.eulerAngles.y) - (joints[i].localRotation.eulerAngles.y / 100 * percentage)), 0);
                else
                {
                    onUnbend.Invoke();
                }
            }
        }
    }
}
