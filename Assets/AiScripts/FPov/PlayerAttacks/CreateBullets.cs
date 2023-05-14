using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBullets : MonoBehaviour
{
    static public CreateBullets instance;
    static GameObject[] pooledObjects;

    [SerializeField]
    GameObject Bullets;

    [SerializeField]
    [Range(1f, 15f)]
    int maxObjects;

    


    void Awake()
    {
        if (instance)
        {
            Destroy(instance);
        }
        else
        {
            instance = this;
        }
        pooledObjects = new GameObject[maxObjects];
        for (int i = 0; i < pooledObjects.Length; i++)
        {
            pooledObjects[i] = Instantiate(Bullets);
            pooledObjects[i].SetActive(false);
        }
    }

    public static GameObject getPooledObject()
    {
        try
        {
            //for each object in the array checks to see if active in game
            foreach (GameObject g in pooledObjects)
            {
                if (g.activeInHierarchy == false)
                {

                    return g;
                }

            }
        }
        catch
        {
            Debug.LogWarning("No Inactive Objects");

        }
        return null;
    }

    
}
