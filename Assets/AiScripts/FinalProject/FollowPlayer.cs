using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using Pada1.BBCore;
using Pada1.BBCore.Actions;
using BBUnity.Actions;

[Action("CustomActions/FollowPlayer")]
public class FollowPlayer : GOAction
{
    public override void OnStart()
    {
        gameObject.GetComponent<NavMeshAgent>().SetDestination(GameObject.FindGameObjectWithTag("Player").transform.position);
    }
}
