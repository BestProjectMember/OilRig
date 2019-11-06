using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestNavigations : MonoBehaviour
{
    public List<GameObject> locations;
    public GameObject questMan;
    public PlayerController pController;
    private int questNumber;

    void Start()
    {
      //  locations = new List<GameObject>();
        questMan = GameObject.Find("Quest board");
        questNumber = questMan.GetComponent<QuestManager>().getQuestNumber();
        print(questNumber);

    }

    public void setLocationForQuest()
    {
        print("locations method called");
        print(locations.Count);
        switch (questNumber)
        {
            case 2:
                pController.GetComponent<PlayerController>().setLocation(locations[0]);
               
                break;

            case 3:
                pController.GetComponent<PlayerController>().setLocation(locations[1]);

                break;
            default:
                pController.GetComponent<PlayerController>().setLocation(null);
                break;
        }
    }
}
