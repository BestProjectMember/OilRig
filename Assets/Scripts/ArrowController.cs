using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    private Arrow arrow;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        arrow = gameObject.GetComponent<Arrow>();
        arrow.SetTarget(target);
    }
}
