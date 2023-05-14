using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Pada1.BBCore;
using Pada1.BBCore.Actions;
using BBUnity.Actions;

[Action("CustomActions/Collect")]
public class Collect : GOAction
{

    public override void OnStart()
    {
        NavMeshAgent agent = gameObject.GetComponent<NavMeshAgent>();
        AgentManager agentManager = gameObject.GetComponent<AgentManager>();
        gameObject.GetComponent<NavMeshAgent>().SetDestination(agentManager.collectables[0].position);


    }

}