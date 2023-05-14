using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pada1.BBCore;
using BBUnity.Conditions;
using UnityEngine.AI;

[Condition("CustomConditions/IsHome")]
public class IsHome : GOCondition
{
    public override bool Check()
    {
        return (Vector3.Distance(gameObject.transform.position,GameObject.FindGameObjectWithTag("Home").transform.position) <.5f);
    }
}
