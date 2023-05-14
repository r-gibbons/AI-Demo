using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    Transform playerView;

    [SerializeField]
    Rigidbody player;

    [SerializeField]
    GameObject pivotPoint;

    Vector3 forwardDir;
    Vector3 SideDir;
    Vector3 dir = Vector2.zero;
    Vector3 gravity = new Vector3(0, -9.8f, 0);
    Vector3 Speed = new Vector3(5f, 0, 5f);

    public bool isMoving = false;
    public bool isSprinting = false;
    public bool isCrouching;

    //bool pressed;

    [SerializeField]
    Jump Jumping;
    void Update()
    {
        if (isMoving)
        {
            MoveCharacter();
        }
        else
        { 
            player.velocity = new Vector3(0,player.velocity.y,0);
        }
        
    }
    //handles character movement
    void MoveCharacter()
    {
        isMoving = true;
        forwardDir = new Vector3(playerView.forward.x, 0f, playerView.forward.z);
        SideDir = new Vector3(playerView.right.x, 0f, playerView.right.z);

        Vector3 newDir = forwardDir * dir.y * Speed.z + SideDir * dir.x * Speed.x;
        player.velocity = new Vector3(newDir.x, player.velocity.y, newDir.z);
        //transform.position += newDir*Speed;
        //transform.position = Vector3.Lerp(transform.position, newDir, 1);
    }
    
    void Sprint()
    {
        if (!isCrouching)
        {
            isSprinting = true;
            Speed.x = 10f;
            Speed.z = 10f;
        }
    }
    void StopSprint()
    {
        if (!isCrouching)
        {
            isSprinting=false;
            Speed.x = 5f;
            Speed.z = 5f;
        }
    }
    //stops character movement
    void StopCharacter()
    {
        isMoving = false;
        dir = Vector2.zero;
    }
    
    void StartMove(Vector2 dir)
    {
        this.dir = dir;
        isMoving = true;
    }
    void StartCrouch()
    {
        if (Jumping.isGrounded)
        {
            isCrouching = true;
            if (LeanTween.isTweening(this.gameObject))
            {
                LeanTween.cancel(this.gameObject);
            }
            LeanTween.moveY(this.gameObject, 1.5f, .1f);
            Speed.x = 3f;
            Speed.z = 3f;
        }
    }

    void StopCrouch()
    {
        isCrouching = false;
        if (LeanTween.isTweening(this.gameObject))
        {
            LeanTween.cancel(this.gameObject);
        }
        LeanTween.moveY(this.gameObject, 2f, .1f);
        Speed.x = 5f;
        Speed.z = 5f;
    }
    void LeanRight()
    {
        /*pressed = true;
        pivotPoint.gameObject.SetActive(true);
        pivotPoint.transform.SetParent(playerView,false);
        StartCoroutine(nameof(beginLean));*/
    }
   /* IEnumerator beginLean()
    {*/
       /* while (pressed)
        {
            Vector3 forwardDir = new Vector3(playerView.forward.x, 0f, playerView.forward.z);
            Vector3 SideDir = new Vector3(playerView.right.x, 0f, playerView.right.z);

            Vector3 newDir = forwardDir * dir.y * Speed.z + SideDir * dir.x * Speed.x;
            playerView.transform.RotateAround(pivotPoint.transform.position, SideDir, 5 * Time.deltaTime);
            yield return new WaitForSeconds(.001f);
        }*/
  //  }
    
    void StopLeanRight()
    {
        /*pressed = false;
        playerView.transform.SetParent(pivotPoint.transform,false);
        pivotPoint.gameObject.SetActive(false);*/
    }
    void LeanLeft()
    {
        //pressed = true;
        
    }
   
    void StopLeanLeft()
    {
        //pressed= false;

    }
    
    void OnEnable()
    {
        InputManager.OnMove += StartMove;
        InputManager.stopMove += StopCharacter;
        InputManager.OnSprint += Sprint;
        InputManager.StopSprint += StopSprint;
        InputManager.OnCrouch += StartCrouch;
        InputManager.StopCrouch += StopCrouch;
        InputManager.OnLeanRight += LeanRight;
        InputManager.OnLeanLeft += LeanLeft;
        InputManager.StopLeanLeft += StopLeanLeft;
        InputManager.StopLeanRight += StopLeanRight;
    }
    void OnDisable()
    {
        InputManager.OnMove -= StartMove;
        InputManager.stopMove -= StopCharacter;
        InputManager.OnSprint -= Sprint;
        InputManager.OnCrouch -= StartCrouch;
        InputManager.StopCrouch -= StopCrouch;
        InputManager.OnLeanRight -= LeanRight;
        InputManager.OnLeanLeft -= LeanLeft;
        InputManager.StopLeanLeft -= StopLeanLeft;
        InputManager.StopLeanRight -= StopLeanRight;

    }
}
