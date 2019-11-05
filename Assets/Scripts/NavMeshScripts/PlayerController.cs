﻿using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    //public Camera cam;
    DrawAgentPath path;
    Transform player;
    public GameObject location;

    public NavMeshAgent agent;

    private void Start()
    {
        player = gameObject.GetComponent<Transform>();
        path = gameObject.GetComponent<DrawAgentPath>();
    }
    // Update is called once per frame
    void Update()
    {
        if(location != null)
        {
            if(player.position != location.transform.position)
            {
                path.getPath(location.transform.position);
            }
        }    
    }

    public void setLocation(GameObject location)
    {
        this.location = location;
    }
}
