using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestManager : MonoBehaviour
{
    private List<Quest> questList;
    private List<Quest> mainQuestList;

    private QuestNavigations navigator;

    private QuestLogActivity logActivity;
    
    // Quest Number Counter
    public static int questNumber = 2;
    public static int mainQuestNumber = 1;


    private QuestText questText;
    public static bool questStarted = false;

    // Text Fields
    public GameObject questFieldMain;
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
        mainQuestList = GetComponent<QuestText>().MainQuestList;
        questText = GetComponent<QuestText>();
        navigator = FindObjectOfType<QuestNavigations>();
        logActivity = GetComponent<QuestLogActivity>();

        if (questStarted)
        {
            navigator.GetComponent<QuestNavigations>().setLocationForQuest();
            startText.SetActive(false);
            questFieldMain.SetActive(true);
            questField1.SetActive(true);
            questField2.SetActive(true);
            questField3.SetActive(true);
            questField4.SetActive(true);
            questField5.SetActive(true);
            questText.AddQuestsToList();
            ChangeDisplayedQuests(questNumber);
            ChangeDisplayMainQuests(mainQuestNumber);
        }
        else
        {
            questFieldMain.SetActive(false);
            questField1.SetActive(false);
            questField2.SetActive(false);
            questField3.SetActive(false);
            questField4.SetActive(false);
            questField5.SetActive(false);
        }
    }

    private void Start()
    {
        if (!questStarted && logActivity.active)
        {
            questStarted = true;
            navigator.GetComponent<QuestNavigations>().setLocationForQuest();
            startText.SetActive(false);
            questFieldMain.SetActive(true);
            questField1.SetActive(true);
            questField2.SetActive(true);
            questField3.SetActive(true);
            questField4.SetActive(true);
            questField5.SetActive(true);
            questText.AddQuestsToList();
            ChangeDisplayedQuests(questNumber);
            ChangeDisplayMainQuests(mainQuestNumber);
        }
    }

    public void startQuest()
    {
        if (!questStarted && logActivity.active) {
            questStarted = true;
            navigator.GetComponent<QuestNavigations>().setLocationForQuest();
            startText.SetActive(false);
            questFieldMain.SetActive(true);
            questField1.SetActive(true);
            questField2.SetActive(true);
            questField3.SetActive(true);
            questField4.SetActive(true);
            questField5.SetActive(true);
            questText.AddQuestsToList();
            ChangeDisplayedQuests(questNumber);
            ChangeDisplayMainQuests(mainQuestNumber);
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
            }
            ChangeDisplayedQuests(questNumber);
        }
    }

    public void CompleteMainQuest(int securityCheck)
    {
        if (securityCheck == mainQuestNumber)
        {
            mainQuestList[mainQuestNumber].complete();
            if (mainQuestNumber < mainQuestList.Count)
            {
                mainQuestNumber++;
            }
            ChangeDisplayMainQuests(mainQuestNumber);
            navigator.GetComponent<QuestNavigations>().setLocationForQuest();
        }
    }

    void ChangeDisplayMainQuests(int number)
    {
        questFieldMain.GetComponent<Text>().text = mainQuestList[mainQuestNumber].english.description;
    }


    void ChangeDisplayedQuests(int number)
    {
              questField1.GetComponent<Text>().text = questList[questNumber - 2].english.description;
              questField2.GetComponent<Text>().text = questList[questNumber - 1].english.description;
              questField3.GetComponent<Text>().text = questList[questNumber].english.description;
              questField4.GetComponent<Text>().text = questList[questNumber + 1].english.description;
              questField5.GetComponent<Text>().text = questList[questNumber + 2].english.description;
    }

    public void CompleteQuestTest()
    {
        CompleteQuest(questNumber);
    }

    public void CompleteMainQuesttest()
    {
        
        CompleteMainQuest(mainQuestNumber);
    }

}

