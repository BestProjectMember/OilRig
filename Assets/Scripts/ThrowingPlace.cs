using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowingPlace : MonoBehaviour
{
	public GameObject cube;
	public GameObject snapDropZone;
	public Fire fire;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerEnter(Collider other)
	{
		if (fire.objectThrowable)
		{
			cube.SetActive(false);
			snapDropZone.SetActive(true);
		}
	}
}
