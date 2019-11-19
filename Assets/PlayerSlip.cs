using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSlip : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject origin;
    public float force;
    public GroundCheck check;
    private int toSlide = 0;

    // Update is called once per frame
    void Update()
    {
        check.CastPhysical();
        if(check.floorType == "Oily" && toSlide < 1)
        {
            toSlide++;
            Slip();
        }
        else
        {
            if (check.floorType == "Ground" && toSlide != 0)
            {
                toSlide = 0;
                rb.velocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
            }
                
        }
    }

    public void Slip()
    {
        rb.AddForce(origin.transform.forward * force * Time.deltaTime, ForceMode.Impulse);
        
    }

}
