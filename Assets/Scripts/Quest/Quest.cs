using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest
{
    public QuestContent english;
    public int number;

    public bool isEnglish;

    private bool completed = false;

    public Quest(QuestContent english, int number)
    {
        this.english = english;
        this.number = number;
        isEnglish = false;
    }

    public void complete()
    {
        this.completed = true;
    }

    public bool isCompleted()
    {
        return this.completed;
    }

    public void ChangeLanguageToEnglish()
    {
        isEnglish = true;
    }

    public void ChangeLanguageToDanish()
    {
        isEnglish = false;
    }

    
}
