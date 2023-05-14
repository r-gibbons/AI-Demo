using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GatherAgent : MonoBehaviour, IManageAgent
{
    public Transform home;
    public List<GameObject> seenObjects;
    public List<GameObject> heldObjects;
    public List<GameObject> nearbyObjects;
    public bool pickedUp = false;

    public List<GameObject> agents;

    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Collectable") && !heldObjects.Contains(other.gameObject)){
            nearbyObjects.Add(other.gameObject);
        }
        else if (other.CompareTag("Player"))
        {
            agents.Add(other.gameObject);
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (nearbyObjects.Contains(other.gameObject))
        {
            heldObjects.Remove(other.gameObject);
        }
        else if (other.CompareTag("Player"))
        {
            agents.Remove(other.gameObject);
        }
    }
   
    public void RemoveMemory(GameObject obj)
    {
        seenObjects.Remove(obj);
        seenObjects = seenObjects.OrderBy(go => Vector3.Distance(transform.position, go.transform.position)).ToList();
    }
    public void AddToMemory(GameObject obj)
    {
        seenObjects.Add(obj);
        seenObjects = seenObjects.OrderBy(go => Vector3.Distance(transform.position, go.transform.position)).ToList();
    }   
    public bool CheckMemory()
    {
        return seenObjects.Count > 0;
    }

}