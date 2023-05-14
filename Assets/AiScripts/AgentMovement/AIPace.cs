using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPace : MonoBehaviour
{
    [SerializeField]
    GameObject point1, point2; //make into transform list
    
    GameObject lastPoint, nextPoint;
    float speed = 20;

    void Start()
    {
        lastPoint = point1;
        nextPoint = point2;
        
        InvokeRepeating(nameof(Patrol),0,0.05f);
    }
   
    void Patrol()
    {
        transform.position += speed * Time.deltaTime * transform.forward;
        transform.LookAt(nextPoint.transform);
    }

     

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals(point2.tag)){
            
            lastPoint = point2;
            nextPoint = point1;
            
        }
        else if (collision.gameObject.tag.Equals(point1.tag))
        {
            lastPoint = point1;
            nextPoint = point2;
            
        }
    }


}
