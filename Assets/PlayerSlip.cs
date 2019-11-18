using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSlip : MonoBehaviour
{
    Rigidbody rb;
    public GameObject origin;
    public float force;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Slip()
    {
        rb.AddForce(origin.transform.forward * force * Time.deltaTime, ForceMode.Impulse);
    }

}
