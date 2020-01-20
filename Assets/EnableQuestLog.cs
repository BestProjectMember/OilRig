using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableQuestLog : MonoBehaviour
{
    public GameObject questBoard;
    private bool active;
    // Start is called before the first frame update
    void Start()
    {
        active = true;
        questBoard.SetActive(active);   
    }

    public void enableQuestLog()
    {
        active = !active;
        questBoard.SetActive(active);
    }
}
