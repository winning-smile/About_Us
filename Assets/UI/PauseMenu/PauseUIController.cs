using UnityEngine;
using UnityEngine.UIElements;

public class PauseUIController : MonoBehaviour {
    public PauseUI _PauseUI;

    private void OnValidate() {
        if (!_PauseUI) {
            _PauseUI = GetComponentInChildren<PauseUI>();
        }
    }
}