using UnityEngine;
using UnityEngine.UI;

public class Data : MonoBehaviour
{
    public Text x;
    public Text y;
    public Text z;

    public GameObject lookForData;

    // Update is called once per frame
    void Update()
    {
        x.text = lookForData.transform.position.x.ToString();
        y.text = lookForData.transform.position.y.ToString();
        z.text = lookForData.transform.position.z.ToString();
    }
}
