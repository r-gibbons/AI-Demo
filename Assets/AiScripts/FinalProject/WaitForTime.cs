using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using Pada1.BBCore;
using Pada1.BBCore.Actions;
using BBUnity.Actions;
using System.Collections;

[Action("CustomActions/WaitForTime")]
public class WaitForTime : GOAction
{
    public override void OnStart()
    {
        gameObject.GetComponent<AIManager>().BeginWait();

    }
    
}
