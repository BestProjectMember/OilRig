using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestLogActivity : MonoBehaviour
{
    GameObject questLog;
    public bool active;

    void Start()
    {
        questLog = GameObject.Find("Quest board");
        questLog.SetActive(false);
        active = false;
    }

    public void enableQuestLog()
    {
        questLog.SetActive(!questLog.activeInHierarchy);
        active = !active;
        print(QuestManager.questNumber);
    }
}
