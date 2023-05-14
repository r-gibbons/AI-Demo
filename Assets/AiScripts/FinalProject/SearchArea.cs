using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using Pada1.BBCore;
using Pada1.BBCore.Actions;
using BBUnity.Actions;

[Action("CustomActions/SearchArea")]
public class SearchArea : GOAction
{
    public override void OnStart()
    {
        if (gameObject.GetComponent<AIManager>().CheckAgentDistance(gameObject.GetComponent<NavMeshAgent>().transform.position, 
            gameObject.GetComponent<NavMeshAgent>().destination) <= 1f)
        {
            Debug.Log(gameObject.GetComponent<AIManager>().searchCount);
            
            gameObject.GetComponent<AIManager>().searchCount++;
            if (gameObject.GetComponent<AIManager>().searchCount == 3)
            {
                gameObject.GetComponent<AIManager>().soundHeard = false;
                gameObject.GetComponent<AIManager>().searchCount = 0;
                gameObject.GetComponent<AIManager>().ArrivedAtSound = false;
            }
            gameObject.GetComponent<NavMeshAgent>().SetDestination(
                (gameObject.GetComponent<AIManager>().soundLocation + new Vector3(Random.Range(-2, 2), 0, Random.Range(-2, 2))));
        }
        
    }
}
