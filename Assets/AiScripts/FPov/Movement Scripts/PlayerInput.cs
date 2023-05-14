//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/AiScripts/FPov/Movement Scripts/PlayerInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Keyboard"",
            ""id"": ""e444330f-b253-47a3-a159-908cdbcc4d74"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""8cd5bff3-3f73-4aa3-9ad8-8e56d1ec4c04"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""b3f6888c-1c3a-4033-9d95-43106ccc9c79"",
                    ""expectedControlType"": ""Digital"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MouseLookX"",
                    ""type"": ""Value"",
                    ""id"": ""805fbde9-7241-4494-b34a-848843192312"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MouseLookY"",
                    ""type"": ""Value"",
                    ""id"": ""c42c2746-8f33-476b-9c68-ae829dcc6a30"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""d76a552b-db3c-481d-a36a-1640fbd62fe0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""4c6d7bc9-51f1-4315-ab75-cd20d0205123"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""ada867b1-0860-484f-93d6-d0966caa0210"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""0b68660c-c8e7-4702-9d8e-80d018597f2e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeanLeft"",
                    ""type"": ""Button"",
                    ""id"": ""dd2d702c-ee9d-427b-a584-c806017df206"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeanRight"",
                    ""type"": ""Button"",
                    ""id"": ""a356ae41-879d-4c32-8583-84c28ddda504"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4328fcaf-1729-4eff-ad19-44c1441b95ae"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""31e4faa1-2d4e-4145-acc2-289ffc221950"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""39dd0f1a-11e0-4b42-a2b7-6ff5eb6f0a6a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""889be5e4-2bb6-4f5a-906d-261f786e791e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7f3ff983-44cf-467f-9bc5-9a774cd1ad0a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""73efb285-5b5d-46f9-9b19-8d7f5f9830d9"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""aea87580-debb-45c2-8283-097508af3da4"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MouseLookX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""59cc7776-5a44-4876-a201-55b02b655e6f"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": ""Invert"",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MouseLookY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a8747184-10d5-4409-b4b1-5d8df80ecd2c"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bf0836b5-4460-46f7-be0c-2c4da95c9a01"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5230666d-24d8-41de-9a25-99b774ef295b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""35a5117b-b75b-4abd-9258-8c2f97e4eed7"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3e5c579c-1ed2-4a24-a91f-648975198d5c"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""LeanLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""99dcc5f0-41bc-4936-ae2f-4d7f51b7992e"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""LeanRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": []
        }
    ]
}");
        // Keyboard
        m_Keyboard = asset.FindActionMap("Keyboard", throwIfNotFound: true);
        m_Keyboard_Jump = m_Keyboard.FindAction("Jump", throwIfNotFound: true);
        m_Keyboard_Movement = m_Keyboard.FindAction("Movement", throwIfNotFound: true);
        m_Keyboard_MouseLookX = m_Keyboard.FindAction("MouseLookX", throwIfNotFound: true);
        m_Keyboard_MouseLookY = m_Keyboard.FindAction("MouseLookY", throwIfNotFound: true);
        m_Keyboard_Sprint = m_Keyboard.FindAction("Sprint", throwIfNotFound: true);
        m_Keyboard_Crouch = m_Keyboard.FindAction("Crouch", throwIfNotFound: true);
        m_Keyboard_Shoot = m_Keyboard.FindAction("Shoot", throwIfNotFound: true);
        m_Keyboard_Interact = m_Keyboard.FindAction("Interact", throwIfNotFound: true);
        m_Keyboard_LeanLeft = m_Keyboard.FindAction("LeanLeft", throwIfNotFound: true);
        m_Keyboard_LeanRight = m_Keyboard.FindAction("LeanRight", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Keyboard
    private readonly InputActionMap m_Keyboard;
    private IKeyboardActions m_KeyboardActionsCallbackInterface;
    private readonly InputAction m_Keyboard_Jump;
    private readonly InputAction m_Keyboard_Movement;
    private readonly InputAction m_Keyboard_MouseLookX;
    private readonly InputAction m_Keyboard_MouseLookY;
    private readonly InputAction m_Keyboard_Sprint;
    private readonly InputAction m_Keyboard_Crouch;
    private readonly InputAction m_Keyboard_Shoot;
    private readonly InputAction m_Keyboard_Interact;
    private readonly InputAction m_Keyboard_LeanLeft;
    private readonly InputAction m_Keyboard_LeanRight;
    public struct KeyboardActions
    {
        private @PlayerInput m_Wrapper;
        public KeyboardActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Keyboard_Jump;
        public InputAction @Movement => m_Wrapper.m_Keyboard_Movement;
        public InputAction @MouseLookX => m_Wrapper.m_Keyboard_MouseLookX;
        public InputAction @MouseLookY => m_Wrapper.m_Keyboard_MouseLookY;
        public InputAction @Sprint => m_Wrapper.m_Keyboard_Sprint;
        public InputAction @Crouch => m_Wrapper.m_Keyboard_Crouch;
        public InputAction @Shoot => m_Wrapper.m_Keyboard_Shoot;
        public InputAction @Interact => m_Wrapper.m_Keyboard_Interact;
        public InputAction @LeanLeft => m_Wrapper.m_Keyboard_LeanLeft;
        public InputAction @LeanRight => m_Wrapper.m_Keyboard_LeanRight;
        public InputActionMap Get() { return m_Wrapper.m_Keyboard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyboardActions set) { return set.Get(); }
        public void SetCallbacks(IKeyboardActions instance)
        {
            if (m_Wrapper.m_KeyboardActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnJump;
                @Movement.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnMovement;
                @MouseLookX.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnMouseLookX;
                @MouseLookX.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnMouseLookX;
                @MouseLookX.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnMouseLookX;
                @MouseLookY.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnMouseLookY;
                @MouseLookY.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnMouseLookY;
                @MouseLookY.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnMouseLookY;
                @Sprint.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnSprint;
                @Crouch.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnCrouch;
                @Shoot.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnShoot;
                @Interact.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnInteract;
                @LeanLeft.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnLeanLeft;
                @LeanLeft.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnLeanLeft;
                @LeanLeft.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnLeanLeft;
                @LeanRight.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnLeanRight;
                @LeanRight.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnLeanRight;
                @LeanRight.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnLeanRight;
            }
            m_Wrapper.m_KeyboardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @MouseLookX.started += instance.OnMouseLookX;
                @MouseLookX.performed += instance.OnMouseLookX;
                @MouseLookX.canceled += instance.OnMouseLookX;
                @MouseLookY.started += instance.OnMouseLookY;
                @MouseLookY.performed += instance.OnMouseLookY;
                @MouseLookY.canceled += instance.OnMouseLookY;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @LeanLeft.started += instance.OnLeanLeft;
                @LeanLeft.performed += instance.OnLeanLeft;
                @LeanLeft.canceled += instance.OnLeanLeft;
                @LeanRight.started += instance.OnLeanRight;
                @LeanRight.performed += instance.OnLeanRight;
                @LeanRight.canceled += instance.OnLeanRight;
            }
        }
    }
    public KeyboardActions @Keyboard => new KeyboardActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IKeyboardActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnMouseLookX(InputAction.CallbackContext context);
        void OnMouseLookY(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnLeanLeft(InputAction.CallbackContext context);
        void OnLeanRight(InputAction.CallbackContext context);
    }
}
