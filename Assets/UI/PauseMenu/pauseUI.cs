using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;


public class PauseUI : UIElement {
    private Button _continueButton;
    private Button _settingsButton;
    private Button _exitButton;

    private void OnEnable() {
        _root.style.display = DisplayStyle.None;
        InitButtons();
    }

    private void InitButtons() {
        _continueButton = _root.Q("ContinueButton") as Button;
        _settingsButton = _root.Q("SettingsButton") as Button;
        _exitButton = _root.Q("ExitButton") as Button;

        _continueButton?.RegisterCallback<ClickEvent>(OnContinueButtonClicked);
        _settingsButton?.RegisterCallback<ClickEvent>(OnMenuButtonClicked);
        _exitButton?.RegisterCallback<ClickEvent>(OnExitButtonClicked);
    }

    private void OnContinueButtonClicked(ClickEvent evt) {
        GameEvents.SwitchPause(0);
    }

    private void OnExitButtonClicked(ClickEvent evt) {
        Application.Quit();
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#endif
    }

    private void OnMenuButtonClicked(ClickEvent evt) {
        SceneManager.LoadScene("MainMenu");
    }
}