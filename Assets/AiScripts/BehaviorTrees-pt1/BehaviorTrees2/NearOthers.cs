using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pada1.BBCore;
using BBUnity.Conditions;
using UnityEngine.AI;

[Condition("CustomConditions/NearOthers")]
public class NearOthers : GOCondition
{
    public override bool Check()
    {
        return (gameObject.GetComponent<GatherAgent>().agents.Count >= 2);
    }
}
