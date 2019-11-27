using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{
    public Transform joint1;
    public Transform joint2;

    public float percentage;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(joint1.rotation.eulerAngles.y);
        //joint1.rotation = Quaternion.Euler(0, ((joint1.rotation.y) - (joint1.rotation.y / 100 * percentage)), 0);
        //joint2.rotation = Quaternion.Euler(0, -(joint2.rotation.y - joint2.rotation.y / 100 * percentage), 0);

    }
}
