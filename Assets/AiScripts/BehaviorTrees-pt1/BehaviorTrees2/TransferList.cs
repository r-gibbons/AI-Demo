using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using Pada1.BBCore;
using Pada1.BBCore.Actions;
using BBUnity.Actions;
using System;
using System.Linq;

[Action("CustomActions/TransferList")]
public class TransferList : GOAction
{
    public override void OnStart()
    {
        Debug.Log("transfering");
        gameObject.GetComponent<NavMeshAgent>().ResetPath();
        List<GameObject> toTransfer = new List<GameObject>();
        List<GameObject> agents = gameObject.GetComponent<GatherAgent>().agents;
        foreach (GameObject go in agents)
        {
            if(go.GetComponent<GatherAgent>().nearbyObjects.Count > toTransfer.Count)
            {
                toTransfer = go.GetComponent<GatherAgent>().nearbyObjects;
            }
        }
        foreach (GameObject go in agents)
        {
            IEnumerable<GameObject> union = toTransfer.Union(go.GetComponent<GatherAgent>().nearbyObjects);
            go.GetComponent<GatherAgent>().nearbyObjects = union.ToList();
        }
        gameObject.GetComponent<GatherAgent>().agents.Clear();


    }
}
