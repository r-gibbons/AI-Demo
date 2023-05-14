using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class AISight : MonoBehaviour
{
    bool playerSeen = false;
    [SerializeField]
    Transform Player;
    [SerializeField]
    NavMeshAgent Agent;
    [SerializeField]
    AIBehavior AIManager;
    [SerializeField]
    Animator thisAnim;

    [SerializeField]
    Rigidbody AgentBody;

    Vector3 playerLocation;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            thisAnim.SetBool("Walk", false);
            thisAnim.SetBool("Idle", false);
            thisAnim.SetBool("Run", true);
            Agent.speed = 10;
            playerSeen = true;
            StopAllCoroutines();
            StartCoroutine(nameof(ChasePlayer));

        }
    }
    IEnumerator ChasePlayer()
    {
        while (playerSeen)
        {
            playerLocation = Player.position;
            Agent.SetDestination(playerLocation);
            yield return new WaitForSeconds(.5f);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            thisAnim.SetBool("Run", false);
            thisAnim.SetBool("Idle", false);
            thisAnim.SetBool("Walk", true);
            playerSeen = false;
            StartCoroutine(nameof(WaitToSearch));
        }
    }
    IEnumerator WaitToSearch()
    {
        while(Agent.remainingDistance > Agent.stoppingDistance){
            if (AgentBody.velocity == Vector3.zero)
            {
                AIManager.StartSearch(playerLocation);
                StopCoroutine(nameof(WaitToSearch));
            }
            yield return new WaitForSeconds(2f);
        }
    }
    
}
