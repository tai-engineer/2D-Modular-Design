using UnityEngine;
using UnityEngine.InputSystem;

namespace GameInput
{ 
    public class InputManager : MonoBehaviour
    {
        public static InputManager instance;

        void Awake()
        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Debug.LogError($"Only one instance of {this.GetType().Name} is allowed.");
                return;
            }

            if(inputControl == null)
                inputControl = new GameInputControl();
            inputControl.GamePlay.Enable();
        }

        public GameInputControl inputControl { get; private set; }
    }
}
