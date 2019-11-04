using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parent : MonoBehaviour
{
    public GameObject getPos;
    public GameObject child;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.parent = getPos.transform;
        gameObject.transform.position = new Vector3(0, 0, 0);
        gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
        gameObject.transform.parent = null;
        child.transform.parent = gameObject.transform;
    }

}
