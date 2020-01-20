using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TestNavmeshcontrol : MonoBehaviour
{
    NavMeshAgent agent;
    public GameObject destination;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(destination.transform.position);
    }
}
