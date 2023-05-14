using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoring : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI text;
    public int score = 0;

    public void increaseScore(int color)
    {
        if (color == 8)
        {
            score += 1;
            text.text = score.ToString();
        }
        else if (color== 9)
        {
            score += 5;
            text.text = score.ToString();
        }
        else if (color == 10)
        {
            score += 10;
            text.text = score.ToString();
        }
    }
}
