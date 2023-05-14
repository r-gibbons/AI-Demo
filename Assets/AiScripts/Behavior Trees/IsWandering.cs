using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BBUnity.Conditions;
using Pada1.BBCore;
using UnityEngine.AI;

[Condition("CustomConditions/IsWandering")]
public class IsWandering : GOCondition
{
    public override bool Check()
    {
        NavMeshAgent navMeshAgent = gameObject.GetComponent<NavMeshAgent>();
        return (navMeshAgent.velocity == Vector3.zero || navMeshAgent.remainingDistance < .5) && !gameObject.GetComponent<AIManager>().soundHeard;
    }
}
