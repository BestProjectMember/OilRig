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

        QuestList.Add(
            new Quest(
                new QuestContent(""),
                0
            )
        );
        QuestList.Add(
            new Quest(
                new QuestContent(""),
                1
            )
        );
        QuestList.Add(
            new Quest(
                new QuestContent("Go to 1st floor"),
                2
            )
        );
        QuestList.Add(
            new Quest(
                new QuestContent("Go to fire floor"),
                3
            )
        );
        QuestList.Add(
            new Quest(
                new QuestContent("Quest 3"),
                4
            )
        );
        QuestList.Add(
            new Quest(
                new QuestContent("Quest 4"),
                5
            )
        );
        QuestList.Add(
            new Quest(
                new QuestContent("Quest 5"),
                6
            )
        );
        QuestList.Add(
             new Quest(
                 new QuestContent(""),
                 7
             )
         );
        QuestList.Add(
            new Quest(
                new QuestContent(""),
                8
            )
        );
    }
}
