using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helmet : MonoBehaviour
{
	public GameObject helmet;
	public GameObject helmetOnHead;
	public bool helmetOn;
    // Start is called before the first frame update
    void Start()
    {
		helmetOn = false;
    }

    // Update is called once per frame
    void Update()
    {
		if (helmetOn)
		{
			helmetOnHead.SetActive(true);
		}
    }

	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("Helmet"))
		{
			helmet.SetActive(false);
			helmetOn = true;
		}
	}
}
