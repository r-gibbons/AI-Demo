using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class InputManager : MonoBehaviour
{
    PlayerInput Actions;
    static InputManager instance;

    public static Action OnJump;

    public static Action OnInteract;

    public static Action OnSprint;
    public static Action StopSprint;

    public static Action OnCrouch;
    public static Action StopCrouch;

    public static Action<Vector2> OnMove;
    public static Action stopMove;

    public static Action<float> OnLookX;
    public static Action<float> OnLookY;

    public static Action OnLeftClick;

    public static Action OnLeanLeft;
    public static Action OnLeanRight;

    public static Action StopLeanLeft;
    public static Action StopLeanRight;

    //ensures there is only one input manager in scene
    void Awake()
     {
        Actions = new PlayerInput();
        if (instance){
            Destroy(gameObject);
         }
        else{
            instance = this;
            }
        }
    

    void OnEnable()
    {
        Actions.Keyboard.Jump.performed += InvokeJump;

        Actions.Keyboard.Interact.performed += InvokeInteract;

        Actions.Keyboard.Movement.performed += InvokeMovement;
        Actions.Keyboard.Movement.canceled += StopMovement;

        Actions.Keyboard.MouseLookX.performed += InvokeLookX;
        Actions.Keyboard.MouseLookY.performed += InvokeLookY;

        Actions.Keyboard.Sprint.performed += InvokeSprint;
        Actions.Keyboard.Sprint.canceled += InvokeStopSprint;

        Actions.Keyboard.Crouch.performed += InvokeCrouch;
        Actions.Keyboard.Crouch.canceled += InvokeStopCrouch;

        Actions.Keyboard.Shoot.performed += InvokeOnShoot;

        Actions.Keyboard.LeanRight.performed += InvokeOnLeanRight;
        Actions.Keyboard.LeanLeft.performed += InvokeOnLeanLeft;

        Actions.Keyboard.LeanRight.canceled += InvokeStopLeanRight;
        Actions.Keyboard.LeanLeft.canceled += InvokeStopLeanLeft;

        Actions.Keyboard.Enable();
    }

    void OnDisable()
    {
        Actions.Keyboard.Jump.canceled -= InvokeJump;

        Actions.Keyboard.Interact.canceled -= InvokeInteract;

        Actions.Keyboard.Movement.performed -= InvokeMovement;

        Actions.Keyboard.MouseLookX.canceled -= InvokeLookX;
        Actions.Keyboard.MouseLookY.canceled -= InvokeLookY;

        Actions.Keyboard.Sprint.performed -= InvokeSprint;

        Actions.Keyboard.Crouch.performed -= InvokeCrouch;

        Actions.Keyboard.Shoot.canceled -= InvokeOnShoot;

        Actions.Keyboard.LeanRight.canceled -= InvokeOnLeanRight;
        Actions.Keyboard.LeanLeft.canceled -= InvokeOnLeanLeft;


        Actions.Keyboard.Disable();
    }
    void InvokeStopLeanRight(InputAction.CallbackContext ctx)
    {
        StopLeanRight.Invoke();
    }
    void InvokeStopLeanLeft(InputAction.CallbackContext ctx)
    {
        StopLeanLeft.Invoke();
    }
    void InvokeOnLeanRight(InputAction.CallbackContext ctx)
    {
        OnLeanRight?.Invoke();
    }
    void InvokeOnLeanLeft(InputAction.CallbackContext ctx)
    {
        OnLeanLeft?.Invoke();
    }

    void InvokeOnShoot(InputAction.CallbackContext ctx)
    {
        OnLeftClick?.Invoke();
    }
    void InvokeCrouch(InputAction.CallbackContext ctx)
    {
        OnCrouch?.Invoke();
    }
    void InvokeStopCrouch(InputAction.CallbackContext ctx)
    {
        StopCrouch?.Invoke();
    }
    void InvokeSprint(InputAction.CallbackContext ctx)
    {
        OnSprint?.Invoke();
    }
    void InvokeStopSprint(InputAction.CallbackContext ctx)
    {
        StopSprint?.Invoke();
    }
    void InvokeLookX(InputAction.CallbackContext ctx)
    {
        OnLookX?.Invoke(ctx.ReadValue<float>());
    }
    void InvokeLookY(InputAction.CallbackContext ctx)
    {
        OnLookY?.Invoke(ctx.ReadValue<float>());
    }

    void InvokeMovement(InputAction.CallbackContext ctx)
    {
        OnMove?.Invoke(ctx.ReadValue<Vector2>());
    }

    void StopMovement(InputAction.CallbackContext ctx)
    {
        stopMove?.Invoke();
    }

    void InvokeJump(InputAction.CallbackContext ctx)
    {
        OnJump?.Invoke();
    }

    void InvokeInteract(InputAction.CallbackContext ctx)
    {
        OnInteract?.Invoke();
    }
}
