using UnityEngine;
using UnityEngine.InputSystem;

namespace UserInput
{ 
    public class UserInputHandler : MonoBehaviour, GameInput.IPlayerActions
    {
        public static UserInputHandler instance;

        ICharacterMove _characterPhysic;
        [SerializeField] GameInput _input;

        void Awake()
        {
            if (instance == null)
                instance = this;
            else
            {
                Debug.LogError($"Only one instance of {this.GetType().Name} is allowed.");
                return;
            }

            if(_input == null)
                _input = new GameInput();

            _input.Player.Enable();
            _input.Player.SetCallbacks(this);

            _characterPhysic = GetComponent<ICharacterMove>();
        }

        void OnDestroy()
        {
            if(_input != null)
                _input.Player.Disable();
        }

        public void OnMove(InputAction.CallbackContext context)
        {
            _characterPhysic?.SetMoveVector(context.ReadValue<Vector2>());
        }

        public void OnJump(InputAction.CallbackContext context)
        {
            throw new System.NotImplementedException();
        }
    }
}
