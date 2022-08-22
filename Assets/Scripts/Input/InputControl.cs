//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/Input/InputControl.inputactions
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

namespace Input
{
    public partial class @InputControl : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @InputControl()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputControl"",
    ""maps"": [
        {
            ""name"": ""GamePlay"",
            ""id"": ""49db0f11-538c-4d3e-9145-a785dfabe969"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""b92f4abf-f881-41d5-943f-14eede0b4beb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""ac892c15-43f6-40a5-a81b-aeab7b1a7657"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""b55c32ea-5b84-4d43-aaf7-73c029d89fec"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e5edf4b1-79dc-4ad1-af83-4f7963e2587b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePlay"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3efadebb-5a48-4e3d-b204-bb842a8760a0"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePlay"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5e68fd48-b966-40d1-814a-e17082b307ed"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePlay"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""31a35d76-3fc2-4fcd-8308-1cbc4fa18f32"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePlay"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d4002c6d-c2a5-4b22-998d-72eaffa970f7"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePlay"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""cfb01fb5-f6ce-450a-a8da-e8166e21b944"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""cf7cdfa6-1448-4957-8dbc-a51728367a83"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""726bfbd4-8030-4b15-a54c-345da6b168f7"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""GamePlay"",
            ""bindingGroup"": ""GamePlay"",
            ""devices"": []
        }
    ]
}");
            // GamePlay
            m_GamePlay = asset.FindActionMap("GamePlay", throwIfNotFound: true);
            m_GamePlay_Move = m_GamePlay.FindAction("Move", throwIfNotFound: true);
            m_GamePlay_Jump = m_GamePlay.FindAction("Jump", throwIfNotFound: true);
            // Menu
            m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
            m_Menu_Move = m_Menu.FindAction("Move", throwIfNotFound: true);
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

        // GamePlay
        private readonly InputActionMap m_GamePlay;
        private IGamePlayActions m_GamePlayActionsCallbackInterface;
        private readonly InputAction m_GamePlay_Move;
        private readonly InputAction m_GamePlay_Jump;
        public struct GamePlayActions
        {
            private @InputControl m_Wrapper;
            public GamePlayActions(@InputControl wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_GamePlay_Move;
            public InputAction @Jump => m_Wrapper.m_GamePlay_Jump;
            public InputActionMap Get() { return m_Wrapper.m_GamePlay; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(GamePlayActions set) { return set.Get(); }
            public void SetCallbacks(IGamePlayActions instance)
            {
                if (m_Wrapper.m_GamePlayActionsCallbackInterface != null)
                {
                    @Move.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMove;
                    @Jump.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnJump;
                    @Jump.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnJump;
                    @Jump.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnJump;
                }
                m_Wrapper.m_GamePlayActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                    @Jump.started += instance.OnJump;
                    @Jump.performed += instance.OnJump;
                    @Jump.canceled += instance.OnJump;
                }
            }
        }
        public GamePlayActions @GamePlay => new GamePlayActions(this);

        // Menu
        private readonly InputActionMap m_Menu;
        private IMenuActions m_MenuActionsCallbackInterface;
        private readonly InputAction m_Menu_Move;
        public struct MenuActions
        {
            private @InputControl m_Wrapper;
            public MenuActions(@InputControl wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_Menu_Move;
            public InputActionMap Get() { return m_Wrapper.m_Menu; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
            public void SetCallbacks(IMenuActions instance)
            {
                if (m_Wrapper.m_MenuActionsCallbackInterface != null)
                {
                    @Move.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnMove;
                }
                m_Wrapper.m_MenuActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                }
            }
        }
        public MenuActions @Menu => new MenuActions(this);
        private int m_GamePlaySchemeIndex = -1;
        public InputControlScheme GamePlayScheme
        {
            get
            {
                if (m_GamePlaySchemeIndex == -1) m_GamePlaySchemeIndex = asset.FindControlSchemeIndex("GamePlay");
                return asset.controlSchemes[m_GamePlaySchemeIndex];
            }
        }
        public interface IGamePlayActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
        }
        public interface IMenuActions
        {
            void OnMove(InputAction.CallbackContext context);
        }
    }
}