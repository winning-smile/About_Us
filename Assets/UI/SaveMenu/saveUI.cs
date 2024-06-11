using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;


public class SaveUI : UIElement {
    [SerializeField]
    private WorldState _worldState;
    
    private Button _continueButton;
    private Button _saveButton;
    
    
    private void OnEnable() {
        _root.style.display = DisplayStyle.None;
        InitButtons();
    }

    private void InitButtons() {
        _continueButton = _root.Q("ContinueButton") as Button;
        _saveButton = _root.Q("SaveButton") as Button;

        _continueButton?.RegisterCallback<ClickEvent>(OnContinueButtonClicked);
        _saveButton?.RegisterCallback<ClickEvent>(OnSaveButtonClicked);
    }

    private void OnContinueButtonClicked(ClickEvent evt) {
        GameEvents.SwitchPause(PauseState.SaveMenu);
    }

    private void OnSaveButtonClicked(ClickEvent evt) {
        _worldState.SaveData();
    }
}