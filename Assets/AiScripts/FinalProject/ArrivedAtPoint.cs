using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pada1.BBCore;
using BBUnity.Conditions;
using UnityEngine.AI;

[Condition("CustomConditions/ArrivedAtPoint")]
public class ArrivedAtPoints : GOCondition
{
    public override bool Check()
    {
        return gameObject.GetComponent<AIManager>().CheckAgentDistance(gameObject.GetComponent<NavMeshAgent>().transform.position,
            gameObject.GetComponent<AIManager>().patrolPoints[gameObject.GetComponent<AIManager>().currentPoint].position) <= 1;
    }
}
