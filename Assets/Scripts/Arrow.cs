using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    GameObject target = null;
    public Transform toFollow;

    void Update()
    {
        if (target != null)
        {
            transform.LookAt(target.transform);
        }

        else
            gameObject.SetActive(false);
    }

    public void SetTarget(GameObject target)
    {
        this.target = target;
    }

    //public void SetTarget(string tag)
    //{
    //    this.target = GameObject.FindGameObjectWithTag(tag);
    //}

    //private void OnEnable()
    //{
    //    ClipboardControl.tagChanged += TagChangeEvent;
    //    if (control.GetCurrentTag() != null)
    //    {
    //        SetTarget(control.GetCurrentTag());
    //    }
    //}
    //private void OnDisable()
    //{
    //    ClipboardControl.tagChanged -= TagChangeEvent;
    //}

    //void TagChangeEvent(string tag)
    //{
    //    if (tag == null)
    //    {
    //        target = null;
    //        return;
    //    }
    //    SetTarget(tag);
    //}
}

