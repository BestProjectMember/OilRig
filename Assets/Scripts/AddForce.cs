using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Malimbe.BehaviourStateRequirementMethod;
using Zinnia.Extension;
using Zinnia.Data.Type;
using UnityEngine.Events;

public class AddForce : MonoBehaviour
{
    Rigidbody rb;
    public float force;
    public GameObject target;
    Vector3 direction;
    public UnityEvent m_MyEvent;
    public Transform origin;

    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector3();
        rb = GetComponent<Rigidbody>();

        if (m_MyEvent == null)
            m_MyEvent = new UnityEvent();

        m_MyEvent.AddListener(Slide);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            m_MyEvent.Invoke();
        }
    }

    public void Slide()
    {
        if(target != null)
        {
            direction.x = target.transform.position.x - transform.position.x;
            direction.z = target.transform.position.z - transform.position.z;
            rb.AddForce(direction * force * Time.deltaTime, ForceMode.Impulse);
        }

    }
}
