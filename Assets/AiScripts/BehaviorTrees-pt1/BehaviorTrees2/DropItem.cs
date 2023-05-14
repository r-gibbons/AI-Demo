using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using Pada1.BBCore;
using Pada1.BBCore.Actions;
using BBUnity.Actions;
using System;

[Action("CustomActions/DropItem")]
public class DropItem : GOAction
{
    public override void OnStart()
    {
        GameObject.FindGameObjectWithTag("Score").GetComponent<Scoring>().increaseScore(gameObject.GetComponent<GatherAgent>().seenObjects[0].layer);
        gameObject.GetComponent<GatherAgent>().seenObjects[0].SetActive(false);
        gameObject.GetComponent<GatherAgent>().RemoveMemory(gameObject.GetComponent<GatherAgent>().seenObjects[0]);
        gameObject.GetComponent<GatherAgent>().pickedUp = false;
        
    }
}
