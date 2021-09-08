// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Units/Player/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace RPG.Units.Player
{
    public class @PlayerControls : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PlayerControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""GameMap"",
            ""id"": ""26c55e7c-6bea-496a-a86e-79bd8149131b"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0421ebfc-ba24-4b62-891a-7e95fc982f99"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FastAttack"",
                    ""type"": ""Button"",
                    ""id"": ""ef569762-49bb-4558-8d05-4f3996ea598e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StrongAttack"",
                    ""type"": ""Button"",
                    ""id"": ""534c9e85-fd58-45ab-b724-2bf61f9b50ba"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""e425c55f-5c4e-4a33-aa80-f175d5b52aba"",
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
                    ""id"": ""5611990e-46e3-473d-99c0-4810d132e972"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1d81f32f-3347-4c3e-a34b-e8e74484b825"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""fb497eb6-209a-4ce8-bc52-f6da1ecb145c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b9e9f698-0125-413c-b62f-ac6f58112288"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7ca72888-6c5f-4313-9722-a816f81d3007"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FastAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""28188d74-c0c7-488f-aac7-122b1c5b84a6"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StrongAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // GameMap
            m_GameMap = asset.FindActionMap("GameMap", throwIfNotFound: true);
            m_GameMap_Movement = m_GameMap.FindAction("Movement", throwIfNotFound: true);
            m_GameMap_FastAttack = m_GameMap.FindAction("FastAttack", throwIfNotFound: true);
            m_GameMap_StrongAttack = m_GameMap.FindAction("StrongAttack", throwIfNotFound: true);
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

        // GameMap
        private readonly InputActionMap m_GameMap;
        private IGameMapActions m_GameMapActionsCallbackInterface;
        private readonly InputAction m_GameMap_Movement;
        private readonly InputAction m_GameMap_FastAttack;
        private readonly InputAction m_GameMap_StrongAttack;
        public struct GameMapActions
        {
            private @PlayerControls m_Wrapper;
            public GameMapActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Movement => m_Wrapper.m_GameMap_Movement;
            public InputAction @FastAttack => m_Wrapper.m_GameMap_FastAttack;
            public InputAction @StrongAttack => m_Wrapper.m_GameMap_StrongAttack;
            public InputActionMap Get() { return m_Wrapper.m_GameMap; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(GameMapActions set) { return set.Get(); }
            public void SetCallbacks(IGameMapActions instance)
            {
                if (m_Wrapper.m_GameMapActionsCallbackInterface != null)
                {
                    @Movement.started -= m_Wrapper.m_GameMapActionsCallbackInterface.OnMovement;
                    @Movement.performed -= m_Wrapper.m_GameMapActionsCallbackInterface.OnMovement;
                    @Movement.canceled -= m_Wrapper.m_GameMapActionsCallbackInterface.OnMovement;
                    @FastAttack.started -= m_Wrapper.m_GameMapActionsCallbackInterface.OnFastAttack;
                    @FastAttack.performed -= m_Wrapper.m_GameMapActionsCallbackInterface.OnFastAttack;
                    @FastAttack.canceled -= m_Wrapper.m_GameMapActionsCallbackInterface.OnFastAttack;
                    @StrongAttack.started -= m_Wrapper.m_GameMapActionsCallbackInterface.OnStrongAttack;
                    @StrongAttack.performed -= m_Wrapper.m_GameMapActionsCallbackInterface.OnStrongAttack;
                    @StrongAttack.canceled -= m_Wrapper.m_GameMapActionsCallbackInterface.OnStrongAttack;
                }
                m_Wrapper.m_GameMapActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Movement.started += instance.OnMovement;
                    @Movement.performed += instance.OnMovement;
                    @Movement.canceled += instance.OnMovement;
                    @FastAttack.started += instance.OnFastAttack;
                    @FastAttack.performed += instance.OnFastAttack;
                    @FastAttack.canceled += instance.OnFastAttack;
                    @StrongAttack.started += instance.OnStrongAttack;
                    @StrongAttack.performed += instance.OnStrongAttack;
                    @StrongAttack.canceled += instance.OnStrongAttack;
                }
            }
        }
        public GameMapActions @GameMap => new GameMapActions(this);
        public interface IGameMapActions
        {
            void OnMovement(InputAction.CallbackContext context);
            void OnFastAttack(InputAction.CallbackContext context);
            void OnStrongAttack(InputAction.CallbackContext context);
        }
    }
}
