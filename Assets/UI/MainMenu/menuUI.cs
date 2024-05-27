using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MenuUI : UIElement {
    private Button _continueButton;
    private Button _newGameButton;
    private Button _loadGameButton;
    private Button _settingsButton;
    private Button _exitButton;

    private void OnEnable() {
        InitButtons();
    }

    private void InitButtons() {
        _continueButton = _root.Q("ContinueButton") as Button;
        _newGameButton = _root.Q("NewGameButton") as Button;
        _loadGameButton = _root.Q("LoadGameButton") as Button;
        _settingsButton = _root.Q("SettingsButton") as Button;
        _exitButton = _root.Q("ExitButton") as Button;

        _continueButton?.RegisterCallback<ClickEvent>(OnContinueButtonClicked);
        _newGameButton?.RegisterCallback<ClickEvent>(OnNewGameButtonClicked);
        _loadGameButton?.RegisterCallback<ClickEvent>(OnLoadGameClicked);
        _settingsButton?.RegisterCallback<ClickEvent>(OnSettingsButtonClicked);
        _exitButton?.RegisterCallback<ClickEvent>(OnExitButtonClicked);
    }

    private void OnContinueButtonClicked(ClickEvent evt) {
    }
    
    private void OnNewGameButtonClicked(ClickEvent evt) {
        SceneManager.LoadScene("Level_1_GLTV");
    }
    
    private void OnLoadGameClicked(ClickEvent evt) {
    }
    
    private void OnSettingsButtonClicked(ClickEvent evt) {
    }

    private void OnExitButtonClicked(ClickEvent evt) {
        Application.Quit();
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#endif
    }
}