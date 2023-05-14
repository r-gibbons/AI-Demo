using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BBUnity.Conditions;
using Pada1.BBCore;



[Condition("CustomConditions/HasSeen")]
public class HasSeenCollectable : GOCondition
{
    public override bool Check()
    {
        return (gameObject.GetComponent<AgentManager>().collectables.Count > 0 && gameObject.GetComponent<AgentManager>().hasCollected);
    }
}