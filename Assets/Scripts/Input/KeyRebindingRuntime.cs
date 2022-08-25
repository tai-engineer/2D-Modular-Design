using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using GameInput;
using TMPro;
public class KeyRebindingRuntime : MonoBehaviour
{
    public static List<KeyRebindingRuntime> rebindActions;
    public string actionName;
    public int bindingIndex;
    [SerializeField] TMP_Text _displayText;
    InputActionRebindingExtensions.RebindingOperation _rebindingOperation;
    InputAction _action;

    string _currentBindingText;
    void OnEnable()
    {
        if(rebindActions == null)
            rebindActions = new List<KeyRebindingRuntime>();
        rebindActions.Add(this);
    }

    void OnDisable()
    {
        rebindActions.Remove(this);
        if (rebindActions.Count == 0)
            rebindActions = null;
        CleanUp();
    }
    void Start()
    {
        _action = InputManager.instance.inputControl.FindAction(actionName);
    }

    public void StartRebinding()
    {
        _action.Disable();

        _currentBindingText = InputControlPath.ToHumanReadableString(_action.bindings[bindingIndex].effectivePath,
            InputControlPath.HumanReadableStringOptions.OmitDevice);

        if (bindingIndex == 0)
        {
            _rebindingOperation = _action.PerformInteractiveRebinding();
        }
        else if (bindingIndex < _action.bindings.Count && _action.bindings[bindingIndex].isPartOfComposite)
        {
            _rebindingOperation = _action.PerformInteractiveRebinding(bindingIndex);
        }

        _rebindingOperation.WithCancelingThrough("<Keyboard>/escape")
                .WithControlsExcluding("Mouse")
                .OnMatchWaitForAnother(0.1f)
                .OnComplete(operation => RebindComplete())
                .OnCancel(operation => RebindCancel())
                .Start();
    }

    void RebindComplete()
    {
        var newPath = InputControlPath.ToHumanReadableString(_action.bindings[bindingIndex].effectivePath,
                    InputControlPath.HumanReadableStringOptions.OmitDevice);
        UpdateDisplayUI(newPath);
        RemoveOverlappedKey();
        CleanUp();
    }

    public void UpdateDisplayUI(string newText)
    {
        _displayText.text = newText;
    }

    void RebindCancel()
    {        
        _displayText.text = _currentBindingText;
        CleanUp();
    }

    void CleanUp()
    {
        _action.Enable();
        _rebindingOperation?.Dispose();
        _rebindingOperation = null;
    }

    void RemoveOverlappedKey()
    {
        foreach (var rebindAction in rebindActions)
        {
            if (rebindAction.actionName == actionName && rebindAction.bindingIndex == bindingIndex)
                continue;

            var action = InputManager.instance.inputControl.FindAction(rebindAction.actionName);
            if (action.bindings[rebindAction.bindingIndex].effectivePath == _action.bindings[bindingIndex].effectivePath)
            {
                action.ApplyBindingOverride(rebindAction.bindingIndex, "");
                rebindAction.UpdateDisplayUI("");
            }
        }
    }
}