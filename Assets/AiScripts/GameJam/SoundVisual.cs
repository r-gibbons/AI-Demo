using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundVisual : MonoBehaviour
{
    [SerializeField]
    Image soundBar;

    

    float maxSound = 6.5f;

    public void changeSoundBar(float sound)
    {
        soundBar.fillAmount = sound / maxSound;
    }
}
