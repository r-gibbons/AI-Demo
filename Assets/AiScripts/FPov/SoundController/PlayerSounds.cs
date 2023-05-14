using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSounds : MonoBehaviour
{
    [SerializeField]
    PlayerMovement Movement;

    [SerializeField]
    SphereCollider col;

    [SerializeField]
    SoundVisual Svisual;

    [SerializeField]
    Jump Jumping;

    void Update()
    {
        if (Movement.isMoving && !Movement.isCrouching && !Movement.isSprinting && Jumping.isGrounded)
        {
            col.enabled = true;
            col.radius = 4f; ;
            Svisual.changeSoundBar(3.5f);

        }
        else if((Movement.isCrouching && !Jumping.isGrounded)){
            col.enabled = true;
            col.radius = 5f;
            Svisual.changeSoundBar(6f);
        }
        else if (Movement.isMoving && !Movement.isCrouching && Movement.isSprinting)
        {
            col.enabled = true;
            col.radius = 7f;
            Svisual.changeSoundBar(7.5f);
        }
        else if(Movement.isMoving && Movement.isCrouching && Jumping.isGrounded)
        {
            col.enabled = true;
            col.radius = 1f;
            Svisual.changeSoundBar(1f);
        }
        else if (!Jumping.isGrounded)
        {
            col.enabled = true;
            col.radius = 6f;
            Svisual.changeSoundBar(6f);
        }
        else
        {
            col.enabled = false;
            col.radius = .1f;
            Svisual.changeSoundBar(.1f);
        }

    }
}
