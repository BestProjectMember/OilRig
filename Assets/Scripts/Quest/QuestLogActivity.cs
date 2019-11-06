using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestLogActivity : MonoBehaviour
{
     GameObject questLog;
    bool isActive;
    // Start is called before the first frame update
    void Start()
    {
        questLog = GameObject.Find("Interactable questlog");
        questLog.SetActive(false);
        isActive = false;
    }

    void Update()
    {
       
       
    }

    public void enableQuestLog()
    {
        questLog.SetActive(!questLog.activeInHierarchy);
    }
}
