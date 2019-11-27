using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
	public ParticleSystem smoke;
	public GameObject snapDropZone;
	public GameObject burningObject;
	private bool haveSmoked;
	public bool objectThrowable;
	public ParticleSystem fire;
	private float particleSize = 1;

    // Start is called before the first frame update
    void Start()
    {
		haveSmoked = false;
		objectThrowable = false;
    }

    // Update is called once per frame
    void Update()
    {
		
		gameObject.transform.position = new Vector3(burningObject.transform.position.x + 2f, burningObject.transform.position.y, burningObject.transform.position.z + 0.2f);
    }

	void OnParticleCollision(GameObject other)
	{
		if (gameObject.transform.localScale.x > 0)
		{
			//			StartCoroutine("PutOut");
			gameObject.transform.localScale += new Vector3(-0.01f, -0.01f, -0.01f);
		}

		if(gameObject.transform.localScale.x <= 0 && !haveSmoked)
		{
			StartCoroutine("Smoke");
			haveSmoked = true;
		}
	}

/*	private void OnTriggerEnter(Collider other)
	{
		if (gameObject.transform.localScale.x > 0)
		{
			StartCoroutine("PutOut");
		}

		if (gameObject.transform.localScale.x < 0 && !haveSmoked)
		{
			StartCoroutine("Smoke");
			haveSmoked = true;
		}
	}*/

	IEnumerator PutOut()
	{
		/*	gameObject.transform.localScale += new Vector3(-0.1f, -0.1f, -0.1f);
			var main = fire.main;
			particleSize -= 0.1f;
			main.startSize = new ParticleSystem.MinMaxCurve(0f, particleSize);*/
		gameObject.transform.localScale += new Vector3(-0.1f, -0.1f, -0.1f);

		Debug.Log("Put out");

		yield return new WaitForSeconds(1f);
	}

	IEnumerator Smoke()
	{
		fire.Stop();
		smoke.Play();
		yield return new WaitForSeconds(5f);
		smoke.Stop();
		objectThrowable = true;
		gameObject.SetActive(false);
	}
}
