using UnityEngine;

using GameInput;
public class CharacterInput : MonoBehaviour, GameInputControl.IGamePlayActions
{
    ICharacterMove _characterPhysic;
    void Awake()
    {
        _characterPhysic = GetComponent<ICharacterMove>();

        var _inputControl = InputManager.instance.inputControl;
        _inputControl.GamePlay.SetCallbacks(this);
    }
    public void OnJump(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnMove(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        _characterPhysic?.SetMoveVector(context.ReadValue<Vector2>());
    }
}
