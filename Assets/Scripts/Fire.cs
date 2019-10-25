using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
	public ParticleSystem smoke;
	public GameObject snapDropZone;
	public GameObject burningObject;
	public Rigidbody burningObjectRigidbody;
	private bool haveSmoked;
	public bool objectThrowable;

    // Start is called before the first frame update
    void Start()
    {
		haveSmoked = false;
		objectThrowable = false;
		burningObjectRigidbody.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
	//	gameObject.transform.position = Vector3.Lerp(transform.position,burningObject.transform.position,Time.time);
    }

	void OnParticleCollision(GameObject other)
	{
		if (gameObject.transform.localScale.x > 0)
		{
			StartCoroutine("PutOut");
		}

		if(gameObject.transform.localScale.x < 0 && !haveSmoked)
		{
			StartCoroutine("Smoke");
			haveSmoked = true;
		}
	}

	IEnumerator PutOut()
	{
		gameObject.transform.localScale += new Vector3(-0.01f, -0.01f, -0.01f);
		yield return new WaitForSeconds(1f);
	}

	IEnumerator Smoke()
	{
		smoke.Play();
		yield return new WaitForSeconds(5f);
		smoke.Stop();
	//	burningObjectRigidbody.isKinematic = !burningObjectRigidbody.isKinematic;
		objectThrowable = true;
	}
}
