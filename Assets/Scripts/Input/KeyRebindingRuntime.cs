using UnityEngine;
using UnityEngine.InputSystem;
using Input;
using TMPro;
public class KeyRebindingRuntime : MonoBehaviour
{
    InputActionRebindingExtensions.RebindingOperation _rebindingOperation;

    InputAction _action;
    [SerializeField] string _actionName;
    [SerializeField] GameObject _currentBindingGO;
    [SerializeField] GameObject _rebindingGO;

    TMP_Text _rebindingText;
    void Start()
    {
        _action = InputManager.instance.inputControl.FindAction(_actionName);
        _rebindingText = _rebindingGO.GetComponent<TMP_Text>();

        _currentBindingGO.SetActive(true);
        _rebindingGO.SetActive(false);
    }
    public void StartRebinding(int bindingIndex)
    {
        _action.Disable();
        _currentBindingGO.SetActive(false);
        _rebindingGO.SetActive(true);

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
        _rebindingText.text = InputControlPath.ToHumanReadableString(_action.bindings[bindingIndex].effectivePath,
            InputControlPath.HumanReadableStringOptions.OmitDevice);

        _rebindingOperation.Dispose();
        _action.Enable();
    }

    void RebindCancel(int bindingIndex)
    {
        _currentBindingGO.SetActive(true);
        _rebindingGO.SetActive(false);

        _rebindingOperation.Dispose();
        _action.Enable();
    }

}