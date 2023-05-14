using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    Color[] values = { Color.red, Color.green, Color.blue };
    int points;
    [SerializeField]
    GameObject Floor;
    [SerializeField]
    GameObject Collectable;
    [SerializeField]
    int Amount = 1;
    void Awake()
    {
        for (int i = 0; i < Amount; i++)
        {
            Vector3 spawnLocation = new(
                Random.Range(Floor.transform.localScale.x * -5f, Floor.transform.localScale.x * 5f),
                1f,
                Random.Range(Floor.transform.localScale.z * -5f, Floor.transform.localScale.z * 5f));

            GameObject temp = Instantiate(Collectable, spawnLocation, transform.rotation);
            temp.transform.SetParent(this.transform);
            temp.tag = "Collectable";
            Renderer rend = temp.GetComponent<Renderer>();
            points = Random.Range(0, 3);
            rend.material.color = values[points];
            temp.layer = points + 8;
        }



    }
}