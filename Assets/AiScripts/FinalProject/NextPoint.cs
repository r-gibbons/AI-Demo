using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using Pada1.BBCore;
using Pada1.BBCore.Actions;
using BBUnity.Actions;

[Action("CustomActions/NextPoint")]
public class NextPoint : GOAction
{
    public override void OnStart()
    {
       gameObject.GetComponent<NavMeshAgent>().SetDestination(gameObject.GetComponent<AIManager>().IncrementCurrentPoint().position);

    }

}
