using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestNavigations : MonoBehaviour
{
    public static List<GameObject> locations;
    public List<GameObject> tempLocations;
    public PlayerController pController;

    void Awake()
    {
        locations = new List<GameObject>();
        for (int i = 0; i < tempLocations.Count; i++)
        {
            locations.Add(tempLocations[i]);
        }
    }

    public void setLocationForQuest()
    {
        print(QuestManager.mainQuestNumber-1);
        pController.GetComponent<PlayerController>().setLocation(locations[QuestManager.mainQuestNumber - 1]);
    }
}
