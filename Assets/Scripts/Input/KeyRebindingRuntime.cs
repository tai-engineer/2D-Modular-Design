using UnityEngine;
using UnityEngine.InputSystem;
using Input;
using TMPro;
public class KeyRebindingRuntime : MonoBehaviour
{
    InputActionRebindingExtensions.RebindingOperation _rebindingOperation;

    InputAction _action;
    [SerializeField] string _actionName;
    [SerializeField] TMP_Text _displayText;

    string _currentBindingText;
    void Start()
    {
        _action = InputManager.instance.inputControl.FindAction(_actionName);
    }
    public void StartRebinding(int bindingIndex)
    {
        _action.Disable();

        _currentBindingText = InputControlPath.ToHumanReadableString(_action.bindings[bindingIndex].effectivePath,
            InputControlPath.HumanReadableStringOptions.OmitDevice);

        var index = 0;
        if (bindingIndex == -1)
        {
            _rebindingOperation = _action.PerformInteractiveRebinding();
        }
        else if (bindingIndex < _action.bindings.Count && _action.bindings[bindingIndex].isPartOfComposite)
        {
            _rebindingOperation = _action.PerformInteractiveRebinding(bindingIndex);
            index = bindingIndex;
        }

        _rebindingOperation.WithCancelingThrough("<Keyboard>/escape")
                .WithControlsExcluding("Mouse")
                .OnMatchWaitForAnother(0.1f)
                .OnComplete(operation => RebindComplete(index))
                .OnCancel(operation => RebindCancel(index))
                .Start();
    }

    void RebindComplete(int bindingIndex)
    {
        _rebindingOperation.Dispose();
        _action.Enable();

        _displayText.text = InputControlPath.ToHumanReadableString(_action.bindings[bindingIndex].effectivePath,
            InputControlPath.HumanReadableStringOptions.OmitDevice);
    }

    void RebindCancel(int bindingIndex)
    {
        _rebindingOperation.Dispose();
        _action.Enable();

        _displayText.text = _currentBindingText;
    }

}