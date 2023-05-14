using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pada1.BBCore;
using BBUnity.Conditions;
using UnityEngine.AI;

[Condition("CustomConditions/HasSeenPlayer")]
public class HasSeenPlayer : GOCondition
{
    public override bool Check()
    {
        return gameObject.GetComponent<AIManager>().HasSeenPlayer;
    }
}
