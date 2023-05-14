using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using Pada1.BBCore;
using Pada1.BBCore.Actions;
using BBUnity.Actions;

[Action("CustomActions/Pickup")]
public class Pickup : GOAction
{
    public override void OnStart()
    {
        Transform pickUp = gameObject.GetComponent<GatherAgent>().seenObjects[0].transform;
        pickUp.SetParent(gameObject.transform);
        pickUp.position = new Vector3(pickUp.position.x, pickUp.position.y+1,pickUp.position.z);
        gameObject.GetComponent<GatherAgent>().pickedUp = true;
        gameObject.GetComponent<GatherAgent>().seenObjects[0].GetComponent<Collider>().enabled = false;
    }
}
