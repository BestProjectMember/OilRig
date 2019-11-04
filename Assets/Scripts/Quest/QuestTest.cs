using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestTest : MonoBehaviour
{

    public GameObject questLog;
    private QuestManager questManager;
    private int i;
    private GameObject questlog;
    // Start is called before the first frame update
    void Start()
    {
        i = 2;
        questManager = questLog.GetComponent<QuestManager>();
        questlog = GameObject.FindGameObjectWithTag("Quest Log");
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void testQuest()
    {
        print("button pressed");
        if (i < 7)
        {
            questManager.CompleteQuest(i);
            i++;
        }
    }
 
    public void enableQuestlog()
    {
        questlog.SetActive(true);
    }

    public void disableQuestlog()
    {
        questLog.SetActive(false);
    }
}
