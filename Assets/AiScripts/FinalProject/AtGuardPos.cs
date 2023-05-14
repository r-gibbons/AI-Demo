using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pada1.BBCore;
using BBUnity.Conditions;
using UnityEngine.AI;

[Condition("CustomConditions/AtGuardPos")]
public class AtGuardPos : GOCondition
{
    public override bool Check()
    {
        return Vector3.Distance(gameObject.GetComponent<AIManager>().GuardPosition.transform.position, gameObject.GetComponent<NavMeshAgent>().transform.position) < .5f;
    }
}
