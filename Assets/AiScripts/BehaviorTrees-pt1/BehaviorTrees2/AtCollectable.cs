using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pada1.BBCore;
using BBUnity.Conditions;
using UnityEngine.AI;

[Condition("CustomConditions/AtCollectable")]
public class AtCollectable : GOCondition
{
    public override bool Check()
    {
        return Vector3.Distance(gameObject.GetComponent<GatherAgent>().seenObjects[0].transform.position, gameObject.transform.position) < 1;
    }
}
