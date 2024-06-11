using UnityEngine;

public class InputController : MonoBehaviour {
    void Start() {
        GameEvents.OnUIOpen.AddListener(SetPause);
        GameEvents.OnUIClose.AddListener(UnsetPause);
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            GameEvents.SwitchPause(PauseState.PauseMenu);
        }

        if (Input.GetKeyDown(KeyCode.Tab)) {
            GameEvents.SwitchPause(PauseState.InventoryMenu);
        }
    }

    private void SetPause(PauseState state) {
        Time.timeScale = 0;
    }

    private void UnsetPause(PauseState state) {
        Time.timeScale = 1;
    }
}