using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
	public ParticleSystem smoke;
	public GameObject burningObject;
	private bool haveSmoked;
    // Start is called before the first frame update
    void Start()
    {
		haveSmoked = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void OnParticleCollision(GameObject other)
	{
		//	if(other.gameObject.name == "Foam")
		//	{
		if (gameObject.transform.localScale.x > 0)
		{
			Debug.Log("collision enter");
			StartCoroutine("PutOut");
		}

		if(gameObject.transform.localScale.x < 0 && !haveSmoked)
		{
			StartCoroutine("Smoke");
			haveSmoked = true;
		}
	//	}
	}

	IEnumerator PutOut()
	{
		gameObject.transform.localScale += new Vector3(-0.01f, -0.01f, -0.01f);
		Debug.Log("fire scale -0.1");
		yield return new WaitForSeconds(1f);
	}

	IEnumerator Smoke()
	{
		smoke.Play();
		yield return new WaitForSeconds(5f);
		smoke.Stop();
		burningObject.SetActive(false);
	}
}
