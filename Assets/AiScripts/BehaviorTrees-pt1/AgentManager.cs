using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class AgentManager : MonoBehaviour
{
    public List<Transform> collectables;

    public bool hasCollected = false;
    void Start()
    {
        collectables = new List<Transform>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Collectable"))
        {
            hasCollected = true;

            int currentFirst = 0;


            if (collectables == null)
            {
                currentFirst = collectables[0].gameObject.layer;
            }


            if (collectables.Count == 0)
            {
                collectables.Add(other.transform);
            }
            else if (other.gameObject.layer == 10 && currentFirst != 10)
            {
                collectables.Insert(0, other.transform);
            }
            else if (other.gameObject.layer == 9 && currentFirst != 9 && currentFirst != 10)
            {
                collectables.Insert(0, other.transform);
            }
            else if (other.gameObject.layer == 8 && other.transform != collectables[0] && currentFirst != 10 && currentFirst != 9)
            {
                collectables.Insert(0, other.transform);
            }
            else
            {
                collectables.Add(other.transform);
            }


            // .ThenBy(t => Vector3.Distance(transform.position, t.transform.position));


        }
    }
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag.Equals("Collectable"))
        {
            collision.gameObject.SetActive(false);
            collectables.Remove(collision.transform);

            hasCollected = false;
        }
    }
}