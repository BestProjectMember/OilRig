using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnChild : MonoBehaviour
{

    public void unChildObject()
    {
        print("unchild");
        gameObject.transform.parent = null;
    }
}
