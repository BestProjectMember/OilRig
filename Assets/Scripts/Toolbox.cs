using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Prefabs.Interactions.Controllables;
using VRTK.Prefabs.Interactions.Interactables;
using Zinnia.Data.Type;

public class Toolbox : MonoBehaviour
{
	public InteractableFacade leftHandFacade;
	public InteractableFacade righHandFacade;
	public RotationalDriveFacade leftHandDriveFacade;
	public RotationalDriveFacade rightHandDriveFacade;
	public RotationalJointDrive leftJointDrive;
	public RotationalJointDrive rightJointDrive;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		//only when users have grabbed both handle, will users be able to open the toolbox
		if (leftHandFacade.IsGrabbed && righHandFacade.IsGrabbed)
		{
						leftHandDriveFacade.DriveLimit = new FloatRange(-90f, 0f);
						rightHandDriveFacade.DriveLimit = new FloatRange(0f, 90f);
			leftHandDriveFacade.enabled = true;
			rightHandDriveFacade.enabled = true;
			leftJointDrive.enabled = true;
			rightJointDrive.enabled = true;
		}
		else
		{
						leftHandDriveFacade.DriveLimit = new FloatRange(0f, 0f);
						rightHandDriveFacade.DriveLimit = new FloatRange(0f, 0f);
			leftHandDriveFacade.enabled = false;
			rightHandDriveFacade.enabled = false;
			leftJointDrive.enabled = false;
			rightJointDrive.enabled = false;
		}
    }
}
