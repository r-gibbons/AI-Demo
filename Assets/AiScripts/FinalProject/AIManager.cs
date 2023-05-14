using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIManager : MonoBehaviour
{
    [SerializeField]
    string playerTag, agentTag,soundTag;
    public Vector3 soundLocation;
    Vector3 playerLocation;
    [SerializeField]
    NavMeshAgent Agent;

    public int currentPoint=0;
    public List<Transform> patrolPoints;

    
    public GameObject GuardPosition;

    public List<GameObject> NearbyAgents = new List<GameObject>();
    public bool hasSharedInfo = false;
    public bool HasSeenPlayer = false;
    public bool soundHeard = false;
    public int searchCount = 0;
    public bool ArrivedAtSound = false;
    void OnTriggerEnter(Collider other)
    {
        
        if (other.tag.Equals(playerTag))
        {
            StopCoroutine(nameof(ChaseDelay));
            HasSeenPlayer = true;
            playerLocation = other.transform.position;
        }
        else if (other.tag.Equals(agentTag))
        {
            if (!NearbyAgents.Contains(other.gameObject))
            {
                NearbyAgents.Add(other.gameObject);
            }
        }
        else if (other.tag.Equals(soundTag))
        {
            soundHeard = true;
            soundLocation= other.GetComponent<Transform>().position;
        }
    }
    void OnTriggerExit(Collider other)
    {
        
        if (other.tag.Equals(playerTag))
        {
            StartCoroutine(nameof(ChaseDelay));
        }
        else if (other.tag.Equals(agentTag))
        {
            NearbyAgents.Remove(other.gameObject);
        }
    }
    IEnumerator ChaseDelay()
    {
        yield return new WaitForSeconds(3f);
        HasSeenPlayer = false;
    }

    public void BeginWait()
    {
        StartCoroutine(nameof(WaitAtPosition));
    }
    IEnumerator WaitAtPosition()
    {
        yield return new WaitForSeconds(2f);
    }
    public bool CheckPath()
    {
        for(int i=0; i < patrolPoints.Count; i++)
        {
            if (Vector3.Distance(patrolPoints[i].position,Agent.destination)<=1)
            {
                return true;
            }
        }
        return false;
    }
    public Transform IncrementCurrentPoint()
    {
        if(currentPoint < patrolPoints.Count-1)
        {
            currentPoint++;
        }
        else if(currentPoint == patrolPoints.Count - 1)
        {
            currentPoint = 0;
        }
        return patrolPoints[currentPoint];
    }

    public float CheckAgentDistance(Vector3 currentPos, Vector3 dest)
    {
        float distance = float.MaxValue;
        NavMeshPath Path = new NavMeshPath();
        if(NavMesh.CalculatePath(currentPos, dest,Agent.areaMask, Path))
        {
            distance = Vector3.Distance(transform.position, Path.corners[0]);

            for (int i = 1; i < Path.corners.Length; i++)
            {
                distance += Vector3.Distance(Path.corners[i - 1], Path.corners[i]);
            }
        }
        return distance;
    }
    public void ShareInfo()
    {
        if (HasSeenPlayer==true)//seen player
        {
            foreach(GameObject g in NearbyAgents)
            {
                g.GetComponent<AIManager>().HasSeenPlayer = true;
                g.GetComponent<AIManager>().hasSharedInfo = true;
            }
        }
        else if (soundHeard == true)
        {
            foreach (GameObject g in NearbyAgents)
            {
                g.GetComponent<AIManager>().soundHeard = true;
                g.GetComponent<AIManager>().soundLocation = this.soundLocation;
                g.GetComponent<AIManager>().hasSharedInfo = true;
            }
        }
        hasSharedInfo = true;
       
    }
  
}
