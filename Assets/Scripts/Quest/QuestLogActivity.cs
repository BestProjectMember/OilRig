using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestLogActivity : MonoBehaviour
{
    public GameObject questLog;
    public bool active;

    void Start()
    {
        questLog.SetActive(false);
        active = false;
    }

    public void enableQuestLog()
    {
        active = !active;
        questLog.SetActive(active);
    }
}
