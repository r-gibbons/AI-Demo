using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityFlock : MonoBehaviour
{
    public float minSpeed = 20.0f; 
    public float turnSpeed = 20.0f; 
    public float randomFreq = 20.0f; 
    public float randomForce = 20.0f; 
    public float toOriginForce = 50.0f; 
    public float toOriginRange = 100.0f;
    public float gravity = 2.0f; 
    public float avoidanceRadius = 50.0f;
    public float avoidanceForce = 20.0f;
    public float followVelocity = 4.0f; 
    public float followRadius = 40.0f; 
    private Transform origin; 
    private Vector3 velocity; 
    private Vector3 normalizedVelocity;
    private Vector3 randomPush; 
    private Vector3 originPush; 
    private Transform[] objects; 
    private UnityFlock[] otherFlocks; 
    private Transform transformComponent; 
    private float randomFreqInterval;

    void Start()
    {
        randomFreqInterval = 1.0f;
        origin = transform.parent;
        transformComponent = transform;
        Component[] tempFlocks = null;
        if (transform.parent)
        {
            tempFlocks = transform.parent.GetComponentsInChildren<UnityFlock>();
        }
        objects = new Transform[tempFlocks.Length];
        otherFlocks = new UnityFlock[tempFlocks.Length];
        for(int i = 0; i < tempFlocks.Length; i++)
        {
            objects[i] = tempFlocks[i].transform;
            otherFlocks[i] = (UnityFlock)tempFlocks[i];
        }
        transform.parent = null;
        StartCoroutine(UpdateRandom());
    }
    IEnumerator UpdateRandom()
    {
        randomPush = Random.insideUnitSphere * randomForce;
        yield return new WaitForSeconds(randomFreqInterval + Random.Range
            (-randomFreqInterval / 2f, randomFreqInterval / 2f));
    }
    void Update()
    {
        float speed = velocity.magnitude;
        Vector3 avgVelocity = Vector3.zero;
        Vector3 avgPosition = Vector3.zero;
        int count = 0;
        Vector3 myPosition = transformComponent.position;
        Vector3 forceV;
        Vector3 toAvg;
        for(int i = 0; i < objects.Length; i++)
        {
            Transform boidTransform = objects[i];
            if(boidTransform != transformComponent)
            {
                Vector3 otherPosition = boidTransform.position;
                avgPosition += otherPosition;
                count++;
                forceV = myPosition - otherPosition;
                float directionMagnitude= forceV.magnitude;
                float forceMagnitude = 0f;

                if(directionMagnitude < followRadius)
                {
                    if(directionMagnitude < avoidanceRadius)
                    {
                        forceMagnitude = 1f - (directionMagnitude / avoidanceRadius);
                        if(directionMagnitude > 0)
                        {
                            avgVelocity += (forceV / directionMagnitude) * forceMagnitude * avoidanceForce;
                        }
                    }
                    forceMagnitude = directionMagnitude / followRadius;
                    UnityFlock tempOtherBoid = otherFlocks[i];
                    avgVelocity += followVelocity * forceMagnitude * tempOtherBoid.normalizedVelocity;
                }
                
            }

        }
        if(count > 0)
        {
            avgVelocity /= count; 
            toAvg = (avgPosition / count) - myPosition; 
        } 
        else 
        { 
            toAvg = Vector3.zero; 
        } 
        forceV = origin.position - myPosition; 
        float leaderDirectionMagnitude = forceV.magnitude; 
        float leaderForceMagnitude = leaderDirectionMagnitude / toOriginRange;
        if (leaderDirectionMagnitude > 0) 
            originPush = leaderForceMagnitude * toOriginForce * (forceV / leaderDirectionMagnitude);

        if (speed < minSpeed && speed > 0) { 
            velocity = (velocity / speed) * minSpeed;
        }
        Vector3 wantedVel = velocity; 
        wantedVel -= wantedVel * Time.deltaTime; 
        wantedVel += randomPush * Time.deltaTime; 
        wantedVel += originPush * Time.deltaTime; 
        wantedVel += avgVelocity * Time.deltaTime; 
        wantedVel += gravity * Time.deltaTime * toAvg.normalized; 
        velocity = Vector3.RotateTowards(velocity, wantedVel, turnSpeed * Time.deltaTime, 100.00f);
        transformComponent.rotation = Quaternion.LookRotation(velocity); 
        transformComponent.Translate(velocity * Time.deltaTime, Space.World); 
        normalizedVelocity = velocity.normalized;

         


        }
    }




