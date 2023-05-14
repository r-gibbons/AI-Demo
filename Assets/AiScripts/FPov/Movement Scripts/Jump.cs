using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Jump : MonoBehaviour
{
    [SerializeField]
    string grounded;

    [SerializeField]
    int MaxJumps;

    [SerializeField]
    Rigidbody body;

    float JumpHeight = 5f;

    public bool isGrounded;
    float distanceToCheck = 2.01f;

    [SerializeField]
    PlayerMovement Movement;
    [SerializeField]
    SphereCollider SoundBox;

    

    void FixedUpdate()
    {
        //StartCoroutine(nameof(groundCheck));
        groundCheck();
    }
    
    void groundCheck()
    {
        RaycastHit hit;
        Vector3 dir = new Vector3(0,-1);
        

        if (Physics.Raycast(transform.position,dir, out hit,distanceToCheck))
        {
                Debug.DrawLine(transform.position, hit.point, Color.red);
                body.useGravity = false;
                body.velocity = new Vector3(body.velocity.x, 0,body.velocity.z);
                isGrounded = true;
        }
        else
        {
            
            isGrounded =false;
            body.useGravity = true;
           // yield return null;
        }
    }
    void ToJump()
    {
        if (isGrounded)
        {
            //JumpSound(10f,true);
            if (Movement.isCrouching)
            {
                LeanTween.moveY(this.gameObject, 2f, 0f);
            }
            body.AddForce(Vector3.up*JumpHeight,ForceMode.Impulse);
        }
       
        
    }

    /*void JumpSound(float size,bool active)
    {
            SoundBox.enabled = active;
            SoundBox.radius = size;
    }*/
    
    void OnEnable()
    {
        InputManager.OnJump += ToJump;
        
    }
    void OnDisable()
    {
        InputManager.OnJump -= ToJump;
        
    }
}



