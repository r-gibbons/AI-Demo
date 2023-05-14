using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BBUnity.Actions;
using Pada1.BBCore;


[Action("CustomActions/SetRandomColor")]
public class ChangeColor : GOAction
{
    public override void OnStart()
    {
        gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV();
    }
}
