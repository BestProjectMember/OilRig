using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Broom : MonoBehaviour
{
    public UnityEvent onClean;

    private void Start()
    {
        if (onClean == null)
            onClean = new UnityEvent();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Oily")
        {
            other.gameObject.SetActive(false);
            onClean.Invoke();
        }
    }
}
