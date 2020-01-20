using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotationOnStart : MonoBehaviour
{
    public float minAngle;
    public float maxAngle;
    float rand;
    public QuestManager qm;
    int temp = 0;

    // Start is called before the first frame update
    void Start()
    {
        rand = Random.Range(minAngle, maxAngle);
        gameObject.transform.rotation = Quaternion.Euler(0, rand, 0);
    }

    public void completeValve()
    {
        if(temp >=1)
        {
            qm.CompleteMainQuest(2);
        }
        temp++;
    }


}
