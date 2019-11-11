using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Prefabs.Interactions.Controllables;
using VRTK.Prefabs.Interactions.Interactables;
using Zinnia.Data.Type;

public class Toolbox : MonoBehaviour
{
	public InteractableFacade leftHandFacade;
	public InteractableFacade rightHandFacade;
	public InteractableFacade handleFacade;
	public BoxCollider bodyCollider;
	public Rigidbody rb;
	public BoxCollider[] leftHandColliders;
	public BoxCollider[] rightHandColliders;

    // Start is called before the first frame update
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {

		//only when users have grabbed both handle, will users be able to open the toolbox
	/*	if (!leftHandFacade.IsGrabbed && !rightHandFacade.IsGrabbed &&!handleFacade.IsGrabbed)
		{
			boxCollider.enabled = true;
		}
		else
		{
			boxCollider.enabled = false;
		}*/

	/*	if (leftHandFacade.IsTouched && rightHandFacade.IsTouched)
		{
			foreach (var i in leftHandColliders){
				i.enabled = true;
			}

			foreach(var i in rightHandColliders)
			{
				i.enabled = true;
			}
		}
		else
		{
			foreach(var i in leftHandColliders)
			{
				i.enabled = false;
			}

			foreach(var i in rightHandColliders)
			{
				i.enabled = false;
			}
		}*/
    }

}
