using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pada1.BBCore;
using BBUnity.Conditions;
using UnityEngine.AI;

[Condition("CustomConditions/NotAtSound")]
public class NotAtSound : GOCondition
{
    public override bool Check()
    { 
        return Vector3.Distance(gameObject.GetComponent<AIManager>().soundLocation,gameObject.GetComponent<NavMeshAgent>().transform.position) > .5f && 
            !gameObject.GetComponent<AIManager>().ArrivedAtSound;
    }
}
