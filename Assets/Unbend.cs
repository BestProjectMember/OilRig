using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unbend : MonoBehaviour
{
    Animator anim;
    int bendnr = 0;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    public void UnbendAnim()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bendnr++;
            anim.SetInteger("BendNr", bendnr);
        }
    }
}
