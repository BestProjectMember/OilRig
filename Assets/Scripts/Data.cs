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
        y.text = (Mathf.Round(lookForData.transform.rotation.x * 100f)).ToString();
    }
}
