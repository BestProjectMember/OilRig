using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainScript : MonoBehaviour
{
    public GameObject chain_start;
    public GameObject chain_end;
    private float maxDist;
    private float dist;
    private Vector3 dist1;
    void Start()
    {
        maxDist = Vector3.Distance(chain_start.transform.position, chain_end.transform.position);
        //print(maxDist);

        dist1 = chain_end.transform.position - chain_start.transform.position;
        print(dist1);
    }


    void Update()
    {
        dist = Vector3.Distance(chain_start.transform.position, chain_end.transform.position);
        if (dist > maxDist)
        {
            chain_end.transform.position = (chain_start.transform.position + dist1).normalized;
                //(chain_end.transform.position - chain_start.transform.position).normalized * maxDist + chain_start.transform.position;
        }
    }
}
