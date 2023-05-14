using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flock : MonoBehaviour
{
    internal FlockController controller;
    private new Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (controller)
        {
            Vector3 relativePos = Steer() * Time.deltaTime;
            if(relativePos != Vector3.zero)
            {
                rigidbody.velocity = relativePos;
            }
            
            float speed = rigidbody.velocity.magnitude;
            if (speed > controller.maxVelocity)
            {
                rigidbody.velocity = rigidbody.velocity.normalized*
                    controller.maxVelocity;
            }
            else if(speed < controller.minVelocity)
            {
                rigidbody.velocity = rigidbody.velocity.normalized *
                    controller.minVelocity;
            }
        }
    }

    Vector3 Steer()
    {
        Vector3 center = controller.flockCenter - transform.position;
        Vector3 velocity = controller.flockVelocity - rigidbody.velocity;
        Vector3 follow = controller.target.localPosition - transform.localPosition;
        Vector3 seperation = Vector3.zero;
        foreach (Flock flock in controller.flockList)
        {
            if (flock != this)
            {
                Vector3 relativePos = transform.localPosition - flock.transform.localPosition;
                seperation += relativePos.normalized;
            }
        }
            Vector3 randomize = new Vector3((Random.value *2)-1
                ,(Random.value*2)-1,
                (Random.value*2)-1);

            randomize.Normalize();
            return(controller.centerWeight * center + 
                controller.velocityWeight * velocity +
                controller.seperateWeight * seperation +
                controller.followWeight * follow +
                controller.randomizeWeight * randomize);
    }

}


