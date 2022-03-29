// GENERATED AUTOMATICALLY FROM 'Assets/Controller.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controller : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controller()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controller"",
    ""maps"": [
        {
            ""name"": ""PlayerController"",
            ""id"": ""d730f892-f4fe-47a1-ba59-8b01885747b2"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""a7769bcb-2fe7-4eb6-b8e8-6983c2a6d3ff"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Camera"",
                    ""type"": ""Value"",
                    ""id"": ""e08bb825-41aa-45e6-82d4-54927424ad17"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraSwitch"",
                    ""type"": ""Button"",
                    ""id"": ""19fa9e5c-79ef-4ebd-b96b-176de775c255"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TiltLeft"",
                    ""type"": ""Button"",
                    ""id"": ""b6025666-cb1d-4891-b0a1-5901f85c33d0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TiltRight"",
                    ""type"": ""Button"",
                    ""id"": ""e9929e62-bff0-436c-8156-e37b8280e7e6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BarrelLeft"",
                    ""type"": ""Button"",
                    ""id"": ""1fe58f0a-c18a-4f0f-a791-4b1c945722c5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BarrelRight"",
                    ""type"": ""Button"",
                    ""id"": ""7304ad82-50cb-41fa-a958-5e46ebeede6f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""LeftStick"",
                    ""id"": ""dbf81bc0-837d-412f-a78b-d869b6b179e8"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b0314f3b-8154-47ce-8889-52e06eaaf7ec"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""259a66fd-5c85-4ddc-9564-541e8c854ad5"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""62d6ac3f-2b66-4ca6-a6ed-8643d01ae755"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f303d9a2-32d5-46db-aa02-0b2cbfaf6e95"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""RightStick"",
                    ""id"": ""3e3fde79-98b8-4921-b409-1c2017aba7d7"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""28a4f3df-d8fd-4c47-9ffa-140b953576b3"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""500ee682-8dbc-4b6a-8c1a-c4db639bc18e"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9c8a2c3f-7ca2-42ad-94e8-61524ab3e7c5"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""87457b09-c0ec-419c-b4e5-5f8730843ca6"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ac90af5a-d07b-45b4-a146-731bc539644d"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""CameraSwitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0e150dac-cbe9-4625-a044-5db671e68bfb"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""TiltLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6357b01a-b4a2-4c70-8b32-347253d0fdec"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""TiltRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""342bd063-6971-49c9-adfc-d7b053557383"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""BarrelLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2c5bbb62-d50b-4bf3-a783-770111594bcb"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""BarrelRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlayerController
        m_PlayerController = asset.FindActionMap("PlayerController", throwIfNotFound: true);
        m_PlayerController_Movement = m_PlayerController.FindAction("Movement", throwIfNotFound: true);
        m_PlayerController_Camera = m_PlayerController.FindAction("Camera", throwIfNotFound: true);
        m_PlayerController_CameraSwitch = m_PlayerController.FindAction("CameraSwitch", throwIfNotFound: true);
        m_PlayerController_TiltLeft = m_PlayerController.FindAction("TiltLeft", throwIfNotFound: true);
        m_PlayerController_TiltRight = m_PlayerController.FindAction("TiltRight", throwIfNotFound: true);
        m_PlayerController_BarrelLeft = m_PlayerController.FindAction("BarrelLeft", throwIfNotFound: true);
        m_PlayerController_BarrelRight = m_PlayerController.FindAction("BarrelRight", throwIfNotFound: true);
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

    // PlayerController
    private readonly InputActionMap m_PlayerController;
    private IPlayerControllerActions m_PlayerControllerActionsCallbackInterface;
    private readonly InputAction m_PlayerController_Movement;
    private readonly InputAction m_PlayerController_Camera;
    private readonly InputAction m_PlayerController_CameraSwitch;
    private readonly InputAction m_PlayerController_TiltLeft;
    private readonly InputAction m_PlayerController_TiltRight;
    private readonly InputAction m_PlayerController_BarrelLeft;
    private readonly InputAction m_PlayerController_BarrelRight;
    public struct PlayerControllerActions
    {
        private @Controller m_Wrapper;
        public PlayerControllerActions(@Controller wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerController_Movement;
        public InputAction @Camera => m_Wrapper.m_PlayerController_Camera;
        public InputAction @CameraSwitch => m_Wrapper.m_PlayerController_CameraSwitch;
        public InputAction @TiltLeft => m_Wrapper.m_PlayerController_TiltLeft;
        public InputAction @TiltRight => m_Wrapper.m_PlayerController_TiltRight;
        public InputAction @BarrelLeft => m_Wrapper.m_PlayerController_BarrelLeft;
        public InputAction @BarrelRight => m_Wrapper.m_PlayerController_BarrelRight;
        public InputActionMap Get() { return m_Wrapper.m_PlayerController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControllerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControllerActions instance)
        {
            if (m_Wrapper.m_PlayerControllerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnMovement;
                @Camera.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnCamera;
                @Camera.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnCamera;
                @Camera.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnCamera;
                @CameraSwitch.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnCameraSwitch;
                @CameraSwitch.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnCameraSwitch;
                @CameraSwitch.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnCameraSwitch;
                @TiltLeft.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnTiltLeft;
                @TiltLeft.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnTiltLeft;
                @TiltLeft.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnTiltLeft;
                @TiltRight.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnTiltRight;
                @TiltRight.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnTiltRight;
                @TiltRight.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnTiltRight;
                @BarrelLeft.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnBarrelLeft;
                @BarrelLeft.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnBarrelLeft;
                @BarrelLeft.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnBarrelLeft;
                @BarrelRight.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnBarrelRight;
                @BarrelRight.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnBarrelRight;
                @BarrelRight.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnBarrelRight;
            }
            m_Wrapper.m_PlayerControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Camera.started += instance.OnCamera;
                @Camera.performed += instance.OnCamera;
                @Camera.canceled += instance.OnCamera;
                @CameraSwitch.started += instance.OnCameraSwitch;
                @CameraSwitch.performed += instance.OnCameraSwitch;
                @CameraSwitch.canceled += instance.OnCameraSwitch;
                @TiltLeft.started += instance.OnTiltLeft;
                @TiltLeft.performed += instance.OnTiltLeft;
                @TiltLeft.canceled += instance.OnTiltLeft;
                @TiltRight.started += instance.OnTiltRight;
                @TiltRight.performed += instance.OnTiltRight;
                @TiltRight.canceled += instance.OnTiltRight;
                @BarrelLeft.started += instance.OnBarrelLeft;
                @BarrelLeft.performed += instance.OnBarrelLeft;
                @BarrelLeft.canceled += instance.OnBarrelLeft;
                @BarrelRight.started += instance.OnBarrelRight;
                @BarrelRight.performed += instance.OnBarrelRight;
                @BarrelRight.canceled += instance.OnBarrelRight;
            }
        }
    }
    public PlayerControllerActions @PlayerController => new PlayerControllerActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IPlayerControllerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnCamera(InputAction.CallbackContext context);
        void OnCameraSwitch(InputAction.CallbackContext context);
        void OnTiltLeft(InputAction.CallbackContext context);
        void OnTiltRight(InputAction.CallbackContext context);
        void OnBarrelLeft(InputAction.CallbackContext context);
        void OnBarrelRight(InputAction.CallbackContext context);
    }
}
