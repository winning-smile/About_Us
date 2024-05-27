using UnityEngine;
using UnityEngine.UIElements;

public class SaveUIController : MonoBehaviour {
    public SaveUI _SaveUI;

    private void OnValidate() {
        if (!_SaveUI) {
            _SaveUI = GetComponentInChildren<SaveUI>();
        }
    }
}