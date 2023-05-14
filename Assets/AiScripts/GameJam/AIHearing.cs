using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIHearing : MonoBehaviour
{
    [SerializeField]
    NavMeshAgent Agent;
    [SerializeField]
    AIBehavior AIBehavior;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Sound"))
        {
            StartCoroutine(WaitForTravel(other));

            
        }
    }
    IEnumerator WaitForTravel(Collider sound)
    {
        Agent.SetDestination(sound.transform.position);
        while (Vector3.Distance(Agent.transform.position, sound.transform.position) > 2f)
        {
            yield return new WaitForSeconds(2f);
        }
        AIBehavior.StartSearch(Agent.transform.position);
    }
}
