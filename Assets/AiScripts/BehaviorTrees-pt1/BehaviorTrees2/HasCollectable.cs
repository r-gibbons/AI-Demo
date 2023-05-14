using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pada1.BBCore;
using BBUnity.Conditions;
using UnityEngine.AI;

[Condition("CustomConditions/HasCollectable")]
public class HasCollectable : GOCondition
{
    public override bool Check()
    {

        return gameObject.GetComponent<GatherAgent>().pickedUp == true;
    }
}
