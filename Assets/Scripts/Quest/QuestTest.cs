using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestTest : MonoBehaviour
{

    public GameObject questLog;
    private QuestManager questManager;
    private int i;
    // Start is called before the first frame update
    void Start()
    {
        i = 2;
        questManager = questLog.GetComponent<QuestManager>();
    }

    // Update is called once per frame
    void Update()
    {
        questManager.CompleteQuest(i);
    }

 
}
