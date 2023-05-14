using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Sight : MonoBehaviour
{
    [SerializeField]
    Movement L;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Waypoint"))
        {
            if(!L.tlist.Contains(other.transform))
                L.tlist.Add(other.transform);
                L.tlist = L.tlist.OrderBy(t => t.name).ToList();
        }
    }
}
