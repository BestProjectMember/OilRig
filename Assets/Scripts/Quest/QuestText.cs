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
        AddQuestsToList();
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
        MainQuestList.Add(
            new Quest(
                new QuestContent("Put on a helmet"),
                5));
        MainQuestList.Add(
            new Quest(
                new QuestContent("Put out fire"),
                6));
        MainQuestList.Add(
            new Quest(
                new QuestContent("Replace burnt material"),
                7));

        MainQuestList.Add(
            new Quest(
                new QuestContent("COMPLETED"),
                8));


        QuestList.Add(
            new Quest(
                new QuestContent(""),
                9
            )
        );
        QuestList.Add(
            new Quest(
                new QuestContent(""),
               10
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
                 new QuestContent("Adjust valve to 0"),
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
            new QuestContent("Go to fire scene"),
            18
        )
    );
        QuestList.Add(
           new Quest(
               new QuestContent("Put on a helmet"),
               19
           )
       );
        QuestList.Add(
          new Quest(
              new QuestContent("Pick up fire extinguisher"),
              20
          )
      );
        QuestList.Add(
          new Quest(
              new QuestContent("Put out fire"),
              21
          )
      );
        QuestList.Add(
        new Quest(
            new QuestContent("Replace burnt object"),
            22
        )
    );
        QuestList.Add(
             new Quest(
                 new QuestContent("COMPLETED"),
                 23
             )
         );
        QuestList.Add(
      new Quest(
          new QuestContent(""),
          24
      )
  );
        QuestList.Add(
             new Quest(
                 new QuestContent(""),
                 25
             )
         );
    }
}
