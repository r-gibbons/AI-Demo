using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pada1.BBCore;
using BBUnity.Conditions;
using UnityEngine.AI;

[Condition("CustomConditions/CloseToArea")]
public class CloseToArea : GOCondition
{
    public override bool Check()
    {
        return Vector3.Distance(gameObject.GetComponent<NavMeshAgent>().destination, gameObject.GetComponent<NavMeshAgent>().transform.position) < .5f;
    }
}
