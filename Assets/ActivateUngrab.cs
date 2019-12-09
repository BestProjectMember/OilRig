using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Prefabs.Interactions.Interactables;
using VRTK.Prefabs.Interactions.Interactors;

public class ActivateUngrab : MonoBehaviour
{
    public InteractorFacade LeftFacade,RightFacade;
    public GameObject grabObject;
    // Start is called before the first frame update
    public void ungrab()
    {
        LeftFacade.Ungrab();
        RightFacade.Ungrab();
    }
}
