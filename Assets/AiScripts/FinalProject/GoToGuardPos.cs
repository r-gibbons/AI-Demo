using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using Pada1.BBCore;
using Pada1.BBCore.Actions;
using BBUnity.Actions;

[Action("CustomActions/GoToGuardPos")]
public class GoToGuardPos : GOAction
{
    public override void OnStart()
    {
        gameObject.GetComponent<NavMeshAgent>().SetDestination(gameObject.GetComponent<AIManager>().GuardPosition.transform.position);

    }

}
