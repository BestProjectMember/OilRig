﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DrawAgentPath : MonoBehaviour
{
    LineRenderer line; //to hold the line Renderer
    //Transform target; //to hold the transform of the target
    NavMeshAgent agent; //to hold the agent of this gameObject
    public Material lineMaterial;

    void Start()
    {
        line = gameObject.GetComponent<LineRenderer>(); //get the line renderer
        agent = gameObject.GetComponent<NavMeshAgent>(); //get the agent
        line.material = lineMaterial;
    }

    public void getPath(Vector3 target)
    {
        line.SetPosition(0, transform.position); //set the line's origin
        agent.SetDestination(target); //create the path
        NavMeshPath path = agent.path;

        StartCoroutine(Draw(path));
        agent.isStopped = true;//add this if you don't want to move the agent
    }

    IEnumerator Draw(NavMeshPath path)
    {
        yield return new WaitForEndOfFrame();
        line.positionCount = path.corners.Length;//set the array of positions to the amount of corners
        for (var i = 0; i < path.corners.Length; i++)
        {
            
            line.SetPosition(i, path.corners[i]); //go through each corner and set that to the line renderer's position
        }
    }
}
