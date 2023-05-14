using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vision : MonoBehaviour
{
    [SerializeField]
    string obsticle;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectable"))
        {
            GatherAgent agent = transform.parent.GetComponent<GatherAgent>();
            if (!agent.seenObjects.Contains(other.gameObject))
            {
                agent.AddToMemory(other.gameObject);
            }

          
        }
    }
}