using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using Pada1.BBCore;
using Pada1.BBCore.Actions;
using BBUnity.Actions;

[Action("CustomActions/TravelToSound")]
public class TavelToSound : GOAction
{
    public override void OnStart()
    {
        gameObject.GetComponent<NavMeshAgent>().SetDestination(gameObject.GetComponent<AIManager>().soundLocation);
        gameObject.GetComponent<AIManager>().ArrivedAtSound = true;
    }
}
