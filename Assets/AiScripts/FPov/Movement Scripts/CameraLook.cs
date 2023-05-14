using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    [SerializeField]
    int Speed;

    float xDir, yDir;
    Vector2 newRot;
    void OnEnable()
    {
        InputManager.OnLookX += XRotate;
        InputManager.OnLookY += YRotate;
    }
    void OnDisable()
    {
        InputManager.OnLookX -= XRotate;
        InputManager.OnLookY -= YRotate;
    }

    void DoRotate()
    {
        newRot += new Vector2(yDir * Time.deltaTime * Speed, xDir * Time.deltaTime * Speed);
        newRot.x = Mathf.Clamp(newRot.x,-80, 80);
        transform.rotation = Quaternion.Euler(newRot);
    }

    void XRotate(float xDir)
    {

        this.xDir = xDir;
        DoRotate();
    }

    void YRotate(float yDir)
    {
        this.yDir = yDir;
        DoRotate();
    }
}
