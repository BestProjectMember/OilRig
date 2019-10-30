using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestManager : MonoBehaviour
{
    private List<Quest> questList;

    // Quest Number Counter
    private int questNumber;
    private bool questComplete;
    private int lastQuest;

    // Language
    public string lang;

    // Text Fields
    public GameObject questField1;
    public GameObject questField2;
    public GameObject questField3;
    public GameObject questField4;
    public GameObject questField5;

    // Start is called before the first frame update
    void Start()
    {
        questList = GetComponent<QuestText>().QuestList;

        questNumber = 2;
        lastQuest = 2;
        lang = "english";
        print(questList[questNumber]);
        ChangeDisplayedQuests(questNumber);
    }

    public void CompleteQuest(int securityCheck)
    {
        if (securityCheck == questNumber)
        {
            questList[questNumber].complete();
            if (questNumber < 8)
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
}

