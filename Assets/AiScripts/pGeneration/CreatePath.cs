using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CreatePath : MonoBehaviour
{
    [SerializeField]
    GameObject mazeWalls;

    [SerializeField]
    GameObject floor;

    float floorSizeX, floorSizeZ;

    [SerializeField]
    List<GameObject> walls = new List<GameObject>();
    List<int> doors = new List<int>();

    string[] dirNames = { "N", "S", "E", "W" };

    float scaleFactorX = 4.5f, scaleFactorZ = 4.5f;
    

    void Awake()
    {
        floorSizeX = floor.transform.localScale.x;
        floorSizeZ = floor.transform.localScale.z;
        StartCoroutine(nameof(CreateMaze));
    }
    IEnumerator CreateMaze()
    {
        for (int i = 0; i <= floor.transform.localScale.z * 3f; i++)
        {
            for (int x = 0; x <= floor.transform.localScale.x * 3f; x++)
            {
                walls.Add(Instantiate(mazeWalls, new Vector3(floorSizeX * scaleFactorX, .5f, floorSizeZ * scaleFactorZ), Quaternion.identity));
                doors.Add(0);
                addDoors();
                scaleFactorX -= 1;


            }
            scaleFactorX = 4.5f;
            scaleFactorZ -= 1f;
        }
        yield return null;
    }
    void addDoors()
    {
        GameObject[] directions = { walls[walls.Count - 1].transform.Find("N").gameObject, walls[walls.Count - 1].transform.Find("S").gameObject,
                walls[walls.Count - 1].transform.Find("E").gameObject,walls[walls.Count - 1].transform.Find("W").gameObject };



        int toRemove = findNeighbor(3);
        if (toRemove != -1)
        {
            directions[toRemove].SetActive(false);
            doors[doors.Count - 1]++;
        }
        toRemove = findNeighbor(-3);
        if (toRemove != -1)
        {
            doors[doors.Count - 1]++;
            directions[toRemove].SetActive(false);
        }
        for (int i = 0; i < directions.Length; i++)
        {
            int doorCount = Random.Range(0, directions.Length - 1);
            if (doorCount != -1)
            {
                for (int x = 0; x < doorCount; x++)
                {

                    doors[doors.Count - 1]++;
                    directions[Random.Range(0, directions.Length)].SetActive(false);

                    

                }
            }
        }
        CorrectEdges(directions);


    }
    void CorrectEdges(GameObject[] directions)
    {
        if(scaleFactorX == 4.5 && scaleFactorZ == 4.5)
        {
            directions[3].SetActive(true);
            directions[1].SetActive(true);
        }
        else if(scaleFactorX != 4.5 && scaleFactorX != -4.5 && scaleFactorZ == 4.5)
        {
            directions[1].SetActive(true);
        }
        else if (scaleFactorX == -4.5 && scaleFactorZ == 4.5)
        {
            directions[1].SetActive(true);
            directions[2].SetActive(true);
        }
        else if (scaleFactorX == 4.5 && scaleFactorZ != 4.5 && scaleFactorZ != -4.5)
        {
            directions[3].SetActive(true);
        }
        else if (scaleFactorX == -4.5 && scaleFactorZ != 4.5 && scaleFactorZ != -4.5)
        {
            directions[2].SetActive(true);
        }
        else if (scaleFactorX == 4.5 && scaleFactorZ == -4.5)
        {
            directions[3].SetActive(true);
            directions[0].SetActive(true);
        }
        else if (scaleFactorX != 4.5 && scaleFactorZ != 4.5 && scaleFactorZ == -4.5)
        {
            directions[0].SetActive(true);
        }
         if (scaleFactorX == -4.5 && scaleFactorZ == -4.5)
        {
            directions[0].SetActive(true);
            directions[2].SetActive(true);
        }

    }
    int findNeighbor(int dir)
    {
        GameObject neighbor = null;
        for (int i = 0; i < walls.Count; i++)
        {
            if (walls[walls.Count - 1].transform.position.x == walls[i].transform.position.x + dir ||
                walls[walls.Count - 1].transform.position.z == walls[i].transform.position.z + dir)
            {
                neighbor = walls[i];
            }
        }
        if (neighbor != null)
        {

            for (int i = 0; i < 4; i++)
            {

                if (neighbor.transform.Find(dirNames[i]).gameObject.activeInHierarchy == false)
                {
                    if (i == 0)
                    {
                        return 1;
                    }
                    else if (i == 1)
                    {
                        return 0;
                    }
                    else if (i == 2)
                    {
                        return 3;
                    }
                    else if (i == 3)
                    {
                        return 2;
                    }
                }
            }


        }
        return -1;
    }

}

