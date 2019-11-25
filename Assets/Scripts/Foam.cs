using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foam : MonoBehaviour
{
	public ParticleSystem smoke;
	public GameObject fire;
	private bool haveSmoked;
	public bool objectThrowable;
	// Start is called before the first frame update
	void Start()
	{
		haveSmoked = false;
		objectThrowable = false;
	}

	// Update is called once per frame
	void Update()
	{
		
	}

	private void OnParticleCollision(GameObject other)
	{
		//	if (other.CompareTag("Fire"))
		{
			if (other.transform.localScale.x > 0)
			{
				//	StartCoroutine("PutOut");
				fire.transform.localScale += new Vector3(-0.1f, -0.1f, -0.1f);
			}

			if (other.transform.localScale.x < 0 && !haveSmoked)
			{
				StartCoroutine("Smoke");
				haveSmoked = true;
			}
			//	}
		}
	}

		IEnumerator PutOut()
		{
			fire.transform.localScale += new Vector3(-0.1f, -0.1f, -0.1f);

			yield return new WaitForSeconds(1f);
		}

		IEnumerator Smoke()
		{
			smoke.Play();
			yield return new WaitForSeconds(5f);
			smoke.Stop();
			objectThrowable = true;
		}
	}

