using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Prefabs.Interactions.Interactables.Grab;

public class ChainTeleportation : MonoBehaviour
{
    private bool isGrabed = false;
    private ActivateUngrab ungrabber;

    void Start()
    {
        ungrabber = gameObject.GetComponent<ActivateUngrab>();
    }
    public void ChainGrabed()
    {
        isGrabed = true;
    }

    public void ChainReleased()
    {
        isGrabed = false;
    }

    public void TeleportAction()
    {
        if (isGrabed)
        {
            ungrabber.ungrab();
        }
    }


}
