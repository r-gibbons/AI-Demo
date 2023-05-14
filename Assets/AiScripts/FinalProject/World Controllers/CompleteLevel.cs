using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteLevel : MonoBehaviour
{
    [SerializeField]
    string playerTag, levelName;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals(playerTag))
        {
            SceneManager.LoadScene(levelName);
        }
    }
}
