using UnityEngine;

public class InputController : MonoBehaviour {
    void Start() {
        GameEvents.OnUIOpen.AddListener(SetPause);
        GameEvents.OnUIClose.AddListener(UnsetPause);
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            GameEvents.SwitchPause(GameState.PauseMenu);
        }

        if (Input.GetKeyDown(KeyCode.Tab)) {
            GameEvents.SwitchPause(GameState.InventoryMenu);
        }
    }

    private void SetPause(GameState state) {
        Time.timeScale = 0;
    }

    private void UnsetPause(GameState state) {
        Time.timeScale = 1;
    }
}