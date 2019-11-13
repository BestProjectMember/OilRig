using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestManager : MonoBehaviour
{
    private List<Quest> questList;

    private QuestNavigations navigator;

    private QuestLogActivity logActivity;
    
    // Quest Number Counter
    public static int questNumber = 2;
    private bool questComplete;
    private static int lastQuest= 2;


    private QuestText questText;
    public static bool questStarted = false;

    // Text Fields
    public GameObject questField1;
    public GameObject questField2;
    public GameObject questField3;
    public GameObject questField4;
    public GameObject questField5;
    public GameObject startText;

    // Start is called before the first frame update
    void Awake()
    {
        questList = GetComponent<QuestText>().QuestList;
        questText = GetComponent<QuestText>();
        navigator = FindObjectOfType<QuestNavigations>();
        logActivity = GetComponent<QuestLogActivity>();

        if (questStarted)
        {
            navigator.GetComponent<QuestNavigations>().setLocationForQuest();
            startText.SetActive(false);
            questField1.SetActive(true);
            questField2.SetActive(true);
            questField3.SetActive(true);
            questField4.SetActive(true);
            questField5.SetActive(true);
            questText.AddQuestsToList();
            ChangeDisplayedQuests(questNumber);
        }
        else
        {
            questField1.SetActive(false);
            questField2.SetActive(false);
            questField3.SetActive(false);
            questField4.SetActive(false);
            questField5.SetActive(false);
        }
        print(logActivity.active);
    }

    public void startQuest()
    {
        if (!questStarted && logActivity.active) {
            questStarted = true;
            navigator.GetComponent<QuestNavigations>().setLocationForQuest();
            startText.SetActive(false);
            questField1.SetActive(true);
            questField2.SetActive(true);
            questField3.SetActive(true);
            questField4.SetActive(true);
            questField5.SetActive(true);
            questText.AddQuestsToList();
            ChangeDisplayedQuests(questNumber);
        }
        
        
    }
    public void CompleteQuest(int securityCheck)
    {
        print("quest completed");
        if (securityCheck == questNumber)
        {
            questList[questNumber].complete();
            if (questNumber < questList.Count - 2)
            {
                questNumber++;
                lastQuest++;
            }
            ChangeDisplayedQuests(questNumber);
            navigator.GetComponent<QuestNavigations>().setLocationForQuest();

        }
    }


    void ChangeDisplayedQuests(int number)
    {
              questField1.GetComponent<Text>().text = questList[questNumber - 2].english.description;
              questField2.GetComponent<Text>().text = questList[questNumber - 1].english.description;
              questField3.GetComponent<Text>().text = questList[questNumber].english.description;
              questField4.GetComponent<Text>().text = questList[questNumber + 1].english.description;
              questField5.GetComponent<Text>().text = questList[questNumber + 2].english.description;
    }

    public int getQuestNumber()
    {
        return questNumber;
    }
}

