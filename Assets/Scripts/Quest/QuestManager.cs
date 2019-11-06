using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestManager : MonoBehaviour
{
    private List<Quest> questList;

    private QuestNavigations navigator;
    
    // Quest Number Counter
    private int questNumber;
    private bool questComplete;
    private int lastQuest;


    private QuestText questText;
    bool questStarted;

    // Language
    public string lang;

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

        questField1.SetActive(false);
        questField2.SetActive(false);
        questField3.SetActive(false);
        questField4.SetActive(false);
        questField5.SetActive(false);

        questStarted = false;
        questNumber = 2;
        lastQuest = 2;
        lang = "english";           
       
    }

    public void startQuest()
    {
        if (!questStarted) {
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
        }
    }

    public void ChangeLanguage(string language)
    {

        if (language == "english")
        {
            for (int i = 0; i < questList.Count; i++)
            {
                questList[questNumber].ChangeLanguageToEnglish();
            }

            lang = "english";
            ChangeDisplayedQuests(questNumber);
        }
        if (language == "danish")
        {
            for (int i = 0; i < questList.Count; i++)
            {
                questList[questNumber].ChangeLanguageToDanish();
            }

            lang = "danish";
            ChangeDisplayedQuests(questNumber);
        }
    }

    void ChangeDisplayedQuests(int number)
    {

        if (lang == "english")
        {
              questField1.GetComponent<Text>().text = questList[questNumber - 2].english.description;
              questField2.GetComponent<Text>().text = questList[questNumber - 1].english.description;
              questField3.GetComponent<Text>().text = questList[questNumber].english.description;
              questField4.GetComponent<Text>().text = questList[questNumber + 1].english.description;
              questField5.GetComponent<Text>().text = questList[questNumber + 2].english.description;
        }
        if (lang == "danish")
        {
             questField1.GetComponent<Text>().text = GetComponent<QuestText>().QuestList[questNumber - 2].danish.description;
             questField2.GetComponent<Text>().text = GetComponent<QuestText>().QuestList[questNumber - 1].danish.description;
             questField3.GetComponent<Text>().text = GetComponent<QuestText>().QuestList[questNumber].danish.description;
             questField4.GetComponent<Text>().text = GetComponent<QuestText>().QuestList[questNumber + 1].danish.description;
             questField5.GetComponent<Text>().text = GetComponent<QuestText>().QuestList[questNumber + 2].danish.description;
        }
    }

    public int getQuestNumber()
    {
        return questNumber;
    }
}

