using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestText : MonoBehaviour
{
    // Quest List
    public List<Quest> QuestList;

    // Start is called before the first frame update
    void Awake()
    {     
        QuestList = new List<Quest>();
    }

    public void AddQuestsToList()
    {
        print("text added");
        QuestList.Add(
            new Quest(
                new QuestContent(""),
                new QuestContent(""),
                0
            )
        );
        QuestList.Add(
            new Quest(
                new QuestContent(""),
                new QuestContent(""),
                1
            )
        );
        QuestList.Add(
            new Quest(
                new QuestContent("Go to 1st floor"),
                new QuestContent("Quest 1 but in Danish"),
                2
            )
        );
        QuestList.Add(
            new Quest(
                new QuestContent("Quest 2"),
                new QuestContent("Quest 2 but in Danish"),
                3
            )
        );
        QuestList.Add(
            new Quest(
                new QuestContent("Quest 3"),
                new QuestContent("Quest 3 but in Danish"),
                4
            )
        );
        QuestList.Add(
            new Quest(
                new QuestContent("Quest 4"),
                new QuestContent("Quest 4 but in Danish"),
                5
            )
        );
        QuestList.Add(
            new Quest(
                new QuestContent("Quest 5"),
                new QuestContent("Quest 5 but in Danish"),
                6
            )
        );
        QuestList.Add(
             new Quest(
                 new QuestContent(""),
                 new QuestContent(""),
                 7
             )
         );
        QuestList.Add(
            new Quest(
                new QuestContent(""),
                new QuestContent(""),
                8
            )
        );
    }
}
