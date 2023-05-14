using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using Pada1.BBCore;
using Pada1.BBCore.Actions;
using BBUnity.Actions;

[Action("CustomActions/Wander")]
public class Wander : GOAction
{
    public override void OnStart()
    {
        GameObject ground = GameObject.Find("Ground");
        Vector3 destination = new
            (Random.Range(ground.transform.localScale.x*-5f, ground.transform.localScale.x * 5f),
            1f,
            Random.Range(ground.transform.localScale.z * -5f, ground.transform.localScale.z * 5f));

        gameObject.GetComponent<NavMeshAgent>().SetDestination(destination);
        
    }
}
