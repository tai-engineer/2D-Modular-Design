using UnityEngine;
using UnityEngine.InputSystem;

namespace Input
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
                inputControl = new InputControl();
            inputControl.GamePlay.Enable();
        }

        public InputControl inputControl { get; private set; }
    }
}
