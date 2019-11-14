using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest
{
    public QuestContent english;
    public int number;

    private bool completed = false;

    public Quest(QuestContent english, int number)
    {
        this.english = english;
        this.number = number;
    }

    public void complete()
    {
        this.completed = true;
    }

    public bool isCompleted()
    {
        return this.completed;
    }
    
}
