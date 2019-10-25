using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Prefabs.Interactions.Interactables;

public class FireExtinguisher : MonoBehaviour
{
	public Transform handleTransform;
	public GameObject body;
	public InteractableFacade interactableFacade;
	public ParticleSystem foam;
	public GameObject nozzle;
	bool triggerIsPressed; //value to detect if the trigger is already pressed, in case users press both left and right trigger to active foam

	// Start is called before the first frame update
	void Start()
	{
		triggerIsPressed = false;
	}

	// Update is called once per frame
	void Update()
	{

		foam.transform.position = nozzle.transform.position;

		//if player grabbs the fire extinguisher but looses hand
		if (!interactableFacade.IsGrabbed && triggerIsPressed)
		{
			handleTransform.Rotate(0, 0, -90);
			foam.Stop();
			triggerIsPressed = false;
		}
	}

	//if player press the handle
	public void Active()
	{
		if (interactableFacade.IsGrabbed && !triggerIsPressed)
		{
			handleTransform.Rotate(0, 0, 90);
			foam.Play();
			triggerIsPressed = true;
		}
	}

	//if player loose the handle
	public void Stop()
	{
		if (interactableFacade.IsGrabbed && triggerIsPressed)
		{
			handleTransform.Rotate(0, 0, -90);
			foam.Stop();
			triggerIsPressed = false;
		}
	}
}
