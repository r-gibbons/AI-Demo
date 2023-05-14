using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    public Vector3 bound;
    public float speed = 100f;
    public float targetReachRadius = 10f;
    private Vector3 initalPosition;
    private Vector3 nextMovementPoint;

    void Start()
    {
        initalPosition = transform.position;
        CalculateNextPoint();
    }
    void CalculateNextPoint()
    {
        float posX = Random.Range(initalPosition.x = bound.x, initalPosition.x + bound.x);
        float posY = Random.Range(initalPosition.y = bound.y, initalPosition.y + bound.y);
        float posZ = Random.Range(initalPosition.z=bound.z,initalPosition.z + bound.z);
        nextMovementPoint = initalPosition + new Vector3(posX,posY,posZ);
    }
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation
            (nextMovementPoint - transform.position), Time.deltaTime);
        if(Vector3.Distance(nextMovementPoint, transform.position) <= targetReachRadius)
        {
            CalculateNextPoint();
        }
    }
}
