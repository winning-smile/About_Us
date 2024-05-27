using UnityEngine;

public class InputController : MonoBehaviour {
    void Start() {
        GameEvents.OnUIOpen.AddListener(SetPause);
        GameEvents.OnUIClose.AddListener(UnsetPause);
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            GameEvents.SwitchPause(0);
        }

        if (Input.GetKeyDown(KeyCode.Tab)) {
            GameEvents.SwitchPause(2);
        }
    }

    private void SetPause(int mode) {
        Time.timeScale = 0;
    }

    private void UnsetPause(int mode) {
        Time.timeScale = 1;
    }
}