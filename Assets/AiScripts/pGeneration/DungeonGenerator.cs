/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonGenerator : MonoBehaviour
{
    [SerializeField]
    Vector2 gridSize;
    [SerializeField]
    GameObject nodePrefab;
    [SerializeField]
    Transform plane;

    public float delay = .1f;
    GameObject [,] nodes;
    float nodeSize = 3f;
    float PlaneScaleMultiplier = 10f;
    float planeOffset = 5f;
    Vector2 planeScale;
    Vector2 maxPos;

    void Start()
    {
        planeScale = new(plane.localScale.x, plane.localScale.z);
        maxPos = new(planeScale.x *planeOffset, planeScale.y *planeOffset);
        nodes = new GameObject[(int)(planeScale.x * PlaneScaleMultiplier / nodeSize), (int)(planeScale.y * PlaneScaleMultiplier / nodeSize)];
        StartCoroutine(nameof(Generate));
    }
    IEnumerator Generate()
    {
        int i = 0;
        for (int y = 0; y < planeScale.y * PlaneScaleMultiplier/nodeSize; y++)
        {
            for (int x = 0; x < planeScale.x * PlaneScaleMultiplier / nodeSize; x++) { 
                nodes[i] = Instantiate(nodePrefab, new(-maxPos.x + (3 * y), .5f, -maxPos.y + (3 * x)), Quaternion.identity);
                if (i == 0) //first node always open
                {
                    foreach(Transform obj in nodes[i].transform.GetChild(0).GetComponentInChildren<Transform>())
                    {
                        obj.gameObject.SetActive(false);
                    }
                    //int j = Random.Range(0, 4);
                    //for (int k = 0; k <= j; k++) 
                    //{
                        //nodes[i].transform.GetChild(0).GetChild(Random.Range(0, nodes[i].transform.GetChild(0).childCount)).gameObject.SetActive(false);
                    //}
                }
                i++;
                yield return new WaitForSeconds(delay);

            }
            
        }
        
    }
}
*/