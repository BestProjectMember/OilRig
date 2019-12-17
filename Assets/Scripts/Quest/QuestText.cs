using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestText : MonoBehaviour
{
    // Quest List
    public List<Quest> QuestList;
    public List<Quest> MainQuestList;

    // Start is called before the first frame update
    void Awake()
    {     
        QuestList = new List<Quest>();
        MainQuestList = new List<Quest>();
    }

    public void AddQuestsToList()
    {
        MainQuestList.Add(
            new Quest(
                new QuestContent(" "),
                0));
        MainQuestList.Add(
            new Quest(
                new QuestContent("Attach chain"),
                1));
        MainQuestList.Add(
            new Quest(
                new QuestContent("Adjust valve"),
                2));
        MainQuestList.Add(
            new Quest(
                new QuestContent("Bent pipe"),
                3));
        MainQuestList.Add(
            new Quest(
                new QuestContent("Clean oil"),
                4));
        QuestList.Add(
            new Quest(
                new QuestContent(""),
                5
            )
        );
        QuestList.Add(
            new Quest(
                new QuestContent(""),
               5
            )
        );

        QuestList.Add(
            new Quest(
                new QuestContent("Go to the chain"),
                6
            )
        );
        QuestList.Add(
            new Quest(
                new QuestContent("Attach the chain"),
                7
            )
        );
        QuestList.Add(
            new Quest(
                new QuestContent("Go to 1st floor"),
                8
            )
        );
        QuestList.Add(
             new Quest(
                 new QuestContent("Go to locker room"),
                 9
             )
         );

        QuestList.Add(
             new Quest(
                 new QuestContent("Go to the valve"),
                 10
             )
         );
        QuestList.Add(
             new Quest(
                 new QuestContent("Adjust valve"),
                 11
             )
         );

        QuestList.Add(
             new Quest(
                 new QuestContent("Go to the pipe"),
                12
             )
         );
        QuestList.Add(
             new Quest(
                 new QuestContent("Pick up the hammer"),
                 13
             )
         );

        QuestList.Add(
             new Quest(
                 new QuestContent("Straighten the pipe"),
                 14
             )
         );

        QuestList.Add(
             new Quest(
                 new QuestContent("Go to the oily surface"),
                 15
             )
         );
        QuestList.Add(
             new Quest(
                 new QuestContent("Pick up the broom"),
                 16
             )
         );
        QuestList.Add(
             new Quest(
                 new QuestContent("Clean the oil"),
                 17
             )
         );
        QuestList.Add(
             new Quest(
                 new QuestContent(""),
                 18
             )
         );
        QuestList.Add(
             new Quest(
                 new QuestContent(""),
                 19
             )
         );
    }
}
