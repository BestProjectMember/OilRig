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
    private Vector3 dist2;
    int temp = 0;
    void Start()
    {
        maxDist = Vector3.Distance(chain_start.transform.position, chain_end.transform.position);
        //print(maxDist);

        dist1 = chain_end.transform.position - chain_start.transform.position;
       
        dist2 = new Vector3(chain_end.transform.position.x - chain_start.transform.position.x, 0, chain_end.transform.position.z - chain_start.transform.position.z);
        print(dist2);
    }


    void Update()
    {
        dist = Vector3.Distance(chain_start.transform.position, chain_end.transform.position);
        if (dist > maxDist && temp == 0)
        {
            temp++;
            chain_end.transform.position = (chain_start.transform.position + dist2);
            print(chain_end.transform.position);
            //  chain_end.transform.position= (chain_end.transform.position - chain_start.transform.position).normalized * maxDist + chain_start.transform.position;
        }
    }
}
