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
	public BoxCollider boxCollider;
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
		if (leftHandFacade.IsGrabbed || rightHandFacade.IsGrabbed)
		{
			boxCollider.enabled = false;
		}
		else
		{
			boxCollider.enabled = true;
		}

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
