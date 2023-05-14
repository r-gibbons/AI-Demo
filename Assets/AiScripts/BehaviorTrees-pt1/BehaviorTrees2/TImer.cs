using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TImer : MonoBehaviour
{
    float timer = 0;
    [SerializeField]
    TextMeshProUGUI time;
    [SerializeField]
    Scoring scoring;
  

    // Update is called once per frame
    void Update()
    {
        if (scoring.score < 100)
        {
            timer += Time.deltaTime;
            time.text = timer.ToString();
        }
    }
}
