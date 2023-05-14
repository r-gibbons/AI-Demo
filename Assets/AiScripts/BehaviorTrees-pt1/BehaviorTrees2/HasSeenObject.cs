using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pada1.BBCore;
using BBUnity.Conditions;

[Condition("CustomConditions/HasSeenObject")]
public class HasSeenObject : GOCondition
{
    public override bool Check()
    {

        return gameObject.GetComponent<IManageAgent>().CheckMemory() && !gameObject.GetComponent<GatherAgent>().pickedUp;
    }
}
