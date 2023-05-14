using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pada1.BBCore;
using BBUnity.Conditions;
using UnityEngine.AI;

[Condition("CustomConditions/AgentsNearby")]
public class AgentsNearby : GOCondition
{
    public override bool Check()
    {
        return !gameObject.GetComponent<AIManager>().hasSharedInfo;
    }
}
