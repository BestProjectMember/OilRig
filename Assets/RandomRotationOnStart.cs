using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotationOnStart : MonoBehaviour
{
    public float minAngle;
    public float maxAngle;
    float rand;

    // Start is called before the first frame update
    void Start()
    {
        rand = Random.Range(minAngle, maxAngle);
        gameObject.transform.rotation = Quaternion.Euler(rand, 0, 0);
    }
}
