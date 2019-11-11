using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;

    // Update is called once per frame
    public void LateUpdate()
    {
        transform.position = player.transform.position;
    }
}
