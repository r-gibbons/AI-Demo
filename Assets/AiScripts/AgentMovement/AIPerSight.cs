using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPerSight : MonoBehaviour
{
    [SerializeField]
    int threshold;

    int known;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Obstacle"))
        {
            known++;
        }
        if(known >= threshold)
        {
            Debug.Log("I see them all");
        }
    }

    //disabled in remembers, enabled on forgets
    void OnTriggerExit(Collider other)
    {
        if (other.tag.Equals("Obstacle"))
        {
            //known--;
        }
    }
}
