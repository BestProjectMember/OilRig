using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableObject : MonoBehaviour
{
    public GameObject[] objects;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision");
        //collision.gameObject.SetActive(false);
        //for (int i = 0; i > 0; i++)
        //{
        //    if (collision.gameObject == objects[i].gameObject)
        //    {
                
        //    }
        //}
    }
}
