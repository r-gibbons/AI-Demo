using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public List<Transform> tlist;
    int i = 0;
    float speed = 25f;
    //bool turning = false;
    
    void Start()
    {
        StartCoroutine(CheckArea());
    }
    IEnumerator CheckArea()
    {   for (int i = 0; i < 36; i++)
        {
            transform.Rotate(Vector3.up * 10f);
            yield return new WaitForSeconds(.05f);
        }
        yield return null;
        StartCoroutine(Move());
    }
    IEnumerator Move()
    {
        bool cont = true;
        while (cont)
        {
            
            if (Quaternion.Angle(transform.rotation, Quaternion.LookRotation(tlist[i].position - transform.position)) > .2f)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(tlist[i].position - transform.position), speed * Time.deltaTime);
        }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, tlist[i].position, speed * Time.deltaTime);
                

            }

            if (Vector3.Distance(transform.position, tlist[i].position) <= .2f)
            {
                if (i < tlist.Count-1)
                {
                    i++;
                }
                else
                {
                    i = 0;
                }
                cont = false;
                StopCoroutine(Move());
                StartCoroutine(CheckArea());
            }
            yield return new WaitForSeconds(.05f);
        }
        
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        for (int x = 0; x <= tlist.Count - 1; x++)
        {
            if(x == tlist.Count-1)
                Gizmos.DrawLine(tlist[tlist.Count - 1].position, tlist[0].position);
            else
                Gizmos.DrawLine(tlist[x].position, tlist[x+1].position);
        }
        
    }
}

