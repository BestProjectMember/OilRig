using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestNavigations : MonoBehaviour
{
    public static List<GameObject> locations;
    public List<GameObject> tempLocations;
    public GameObject questMan;
    public PlayerController pController;
    private int questNumber;

    void Start()
    {
        locations = new List<GameObject>();
        for (int i = 0; i < tempLocations.Count; i++)
        {
            locations.Add(tempLocations[i]);
        }
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
                pController.GetComponent<PlayerController>().setLocation(locations[QuestManager.questNumber-2]);
               
                break;

            case 3:
                pController.GetComponent<PlayerController>().setLocation(locations[QuestManager.questNumber-2]);

                break;
            default:
                pController.GetComponent<PlayerController>().setLocation(null);
                break;
        }
    }
}
