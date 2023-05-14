using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using Pada1.BBCore;
using Pada1.BBCore.Actions;
using BBUnity.Actions;

[Action("CustomActions/ShareInfo")]
public class ShareInfo : GOAction
{
    public override void OnStart()
    {
       if(gameObject.GetComponent<AIManager>().NearbyAgents.Count > 0)
        {
            gameObject.GetComponent<AIManager>().ShareInfo();
        }
       else{
            gameObject.GetComponent<AIManager>().hasSharedInfo = true;
        }
    }
}
