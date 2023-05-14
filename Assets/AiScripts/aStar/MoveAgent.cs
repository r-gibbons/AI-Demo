using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAgent : MonoBehaviour
{
    [SerializeField]
    TestCode List;

    int index = 0;
    int speed = 15;
    void Start()
    {
        StartCoroutine(nameof(Move));
    }
    IEnumerator Move()
    {
        /*if (List.pathArray == null)
            yield return new WaitForSeconds(1f);*/
        while (index < List.pathArray.Count)
        {
            transform.position = Vector3.MoveTowards(transform.position, List.pathArray[index].position, speed * Time.deltaTime);
            if (transform.position == List.pathArray[index].position)
            {
                index++;
            }
            yield return new WaitForSeconds(.1f);
        }
        
        yield return new WaitForSeconds(2f);
        StartCoroutine(nameof(Move));
    }
    }
