using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    //public Camera cam;
    DrawAgentPath path;
    Transform player;
    public GameObject location;

    public NavMeshAgent agent;

    private void Start()
    {
        player = gameObject.GetComponent<Transform>();
        path = gameObject.GetComponent<DrawAgentPath>();
        //location.transform.position = player.position;
    }
    // Update is called once per frame
    void Update()
    {
        //if(Input.GetMouseButtonDown(0))
        //{
        //    Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit hit;
            

        //    if(Physics.Raycast(ray, out hit))
        //    {
        //        //agent.SetDestination(hit.point);
        //        location.transform.position = hit.point;
        //        //path.getPath(hit.point);
        //    }
        //}
        if(location != null)
        {
            if(player.position != location.transform.position)
            {
                path.getPath(location.transform.position);
            }
        }
            
    }
}
