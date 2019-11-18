using UnityEngine;

public class AddForce : MonoBehaviour
{
    public GameObject origin;
    public Transform cam;
    Rigidbody rb;
    public float force;
    public GameObject target;
    Vector3 direction;
    public GroundCheck groundCheckRight;
    public GroundCheck groundCheckLeft;

    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector3();
        rb = origin.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            stopSlide();
        }
    }

    public void Slide()
    {
        if(target != null)
        {
            groundCheckRight.Cast();
            groundCheckLeft.Cast();
            if(groundCheckRight.floorType == "Oily" || groundCheckLeft.floorType == "Oily")
            {
                direction.x = target.transform.position.x - cam.transform.position.x;
                direction.z = target.transform.position.z - cam.transform.position.z;
                rb.AddForce(direction * force * Time.deltaTime, ForceMode.Impulse);
            }

        }

    }

    public void stopSlide()
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
}
