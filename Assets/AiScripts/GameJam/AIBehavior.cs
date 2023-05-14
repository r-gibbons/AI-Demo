using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AIBehavior : MonoBehaviour
{
    [SerializeField]
    NavMeshAgent Agent;

    [SerializeField]
    Animator thisAnim;

    [SerializeField]
    Rigidbody AgentBody;

    [SerializeField]
    List<Transform> setPatrol = new List<Transform>();
    [SerializeField]
    List<Transform> inspectArea = new List<Transform> ();

    [SerializeField]
    Terrain Ground;
    

    int[] searchRange = { 3, 5, 6};

    void Start()
    {
        StartCoroutine(nameof(Patrol));
    }
    public void StartSearch(Vector3 playerLocation)
    {
        Agent.speed = 5;
        StopAllCoroutines();
        StartCoroutine(SearchArea(playerLocation));
    }
    IEnumerator SearchArea(Vector3 lastLocation)
    {
        thisAnim.SetBool("Walk", true);
        thisAnim.SetBool("Idle", false);
        thisAnim.SetBool("Run", false);
        int searchAmt = searchRange[Random.Range(0, 3)];
        for (int i = 0; i < searchAmt; i++)
        {
            lastLocation = new Vector3
                (Random.Range(lastLocation.x - 15, lastLocation.x + 10),
                lastLocation.y,
                Random.Range(lastLocation.z - 15, lastLocation.z + 10));
           
            Agent.SetDestination(lastLocation);
            while (Vector3.Distance(Agent.transform.position, lastLocation) > 2f)
            {
                yield return new WaitForSeconds(2f);
            }
            
        }
        StartCoroutine(nameof(Patrol));
    }
    IEnumerator Patrol()
    {
        thisAnim.SetBool("Walk", true);
        thisAnim.SetBool("Idle", false);
        thisAnim.SetBool("Run", false);
        for (int i=0; i < setPatrol.Count; i++)
        {
            Agent.SetDestination(setPatrol[i].position);
            while(Vector3.Distance(Agent.transform.position, setPatrol[i].position) > 2f)
            {
                yield return new WaitForSeconds(2f);
            }
            Debug.Log(thisAnim.GetBool("Walk"));
            StartCoroutine(nameof(LookAround));
            yield return new WaitForSeconds(4);

        }
        StartCoroutine(nameof(TravelObjArea));
    }
    IEnumerator TravelObjArea()
    {
        thisAnim.SetBool("Walk", true);
        thisAnim.SetBool("Idle", false);
        thisAnim.SetBool("Run", false);
        for (int i = 0; i < inspectArea.Count; i++)
        {
            Agent.SetDestination(inspectArea[i].position);
            while (Vector3.Distance(Agent.transform.position, inspectArea[i].position) > 2f)
            {
                yield return new WaitForSeconds(2f);
            }
            StartCoroutine(SearchObjArea(inspectArea[i]));
            yield return new WaitForSeconds(25);

        }
        StartCoroutine(nameof(Patrol));
    }
    IEnumerator SearchObjArea(Transform loc)
    {
        thisAnim.SetBool("Walk", true);
        thisAnim.SetBool("Idle", false);
        thisAnim.SetBool("Run", false);
        Vector3 changedLoc;
        for (int i = 0; i < 4; i++){
            changedLoc = new Vector3(Random.Range(loc.position.x-5, loc.position.x + 5), loc.position.y, Random.Range(loc.position.z-5,loc.position.z+5));
            Agent.SetDestination(changedLoc);
            while (Vector3.Distance(Agent.transform.position, changedLoc) > 2f)
            {
                yield return new WaitForSeconds(1f);
            }
            StartCoroutine(nameof(LookAround));
            
            yield return new WaitForSeconds(4f);
        }

    }
    IEnumerator LookAround()
    {
        thisAnim.SetBool("Walk", false);
        thisAnim.SetBool("Idle", true);
        thisAnim.SetBool("Run", false);
        for (int i = 0; i <= 30; i++)
        {
            transform.Rotate(Vector3.up * 3f);
            yield return new WaitForSeconds(.01f);
        }
        for(int i=0; i<= 60; i++)
        {
            transform.Rotate(Vector3.up * -3f);
            yield return new WaitForSeconds(.02f);
        }
        thisAnim.SetBool("Idle", false);
        thisAnim.SetBool ("Walk", true);
    }
}
