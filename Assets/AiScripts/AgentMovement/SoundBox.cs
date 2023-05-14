using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundBox : MonoBehaviour
{
    [SerializeField]
    AudioSource Sound;
    [SerializeField]
    AudioClip clip;

    Collider soundWave;

    void Start()
    {
        soundWave = GetComponent<Collider>();
        InvokeRepeating(nameof(RepeatSound),0, 4);
    }
    void RepeatSound()
    {

        Sound.PlayOneShot(clip);
        Sound.SetScheduledEndTime(2);
    }
    void Update()
    {
        if (Sound.isPlaying)
        {
            soundWave.enabled = true;
        }
        else
        {
            soundWave.enabled = false;
        }
    }
}
