using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Interact : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI TMPro;

    public bool interacted = false;
    public bool triggerActive = false;   
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player") && !interacted)
        {
            TMPro.text = "Press F to Interact";
            triggerActive = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            TMPro.text = "";
            triggerActive = false;
        }
    }

    void action()
    {
        if (triggerActive)
        {
            interacted = true;
            TMPro.text = "";
        }
    }

    void OnEnable()
    {
        InputManager.OnInteract += action;
    }

    void OnDisable()
    {
        InputManager.OnInteract -= action;
    }
}
