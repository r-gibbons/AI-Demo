using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pada1.BBCore;
using BBUnity.Conditions;
using UnityEngine.AI;

[Condition("CustomConditions/HasNotSearched")]
public class HasNotSearched : GOCondition
{
    public override bool Check()
    { 
        return gameObject.GetComponent<AIManager>().searchCount < 3 && gameObject.GetComponent<AIManager>().ArrivedAtSound == true;
    }
}
