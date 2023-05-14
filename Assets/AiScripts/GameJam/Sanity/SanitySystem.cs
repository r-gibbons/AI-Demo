using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.HID;
using UnityEngine.UI;

public class SanitySystem : MonoBehaviour
{
    [SerializeField]
    Transform cameraTransform;

    

    RaycastHit hit;

    public Image image;
    float distance;
    float maxSanity = 100f;
    float currentSanity = 100f;
    float lossSpeed = 3.5f;
    float gainSpeed = .5f;

    // Update is called once per frame
    void Update()
    {
        if (currentSanity > maxSanity)
        {
            currentSanity = maxSanity;
        }
        else if (currentSanity < 0)
        {
            currentSanity = 0;
        }
        Sanity();
    }

    void Sanity()
    {
        if (Physics.Raycast(cameraTransform.position, cameraTransform.forward, out hit, 20f))
        {
            if (hit.collider.gameObject.tag == "Enemy")
            {
                distance = Vector3.Distance(cameraTransform.position, hit.collider.transform.position);
                float sanityScaler = 1 / distance; ;
                currentSanity -= lossSpeed * sanityScaler;
                UpdateUI();
            }
            else if(currentSanity < 70)
            {
                currentSanity += gainSpeed;
                UpdateUI();
            }
        }
        else if (currentSanity < 70)
        {
            currentSanity += gainSpeed;
            UpdateUI();
        }
    }

    void UpdateUI()
    {
        image.fillAmount = currentSanity / 100;
    }
}
