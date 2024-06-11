using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UIManager : MonoBehaviour {
    [SerializeField]
    private GameObject[] _uiElements;
    private Dictionary<PauseState, GameObject> _uiDictionary = new();

    private void Awake() {
        var i = 0;
        foreach (var uiDoc in _uiElements) {
            _uiDictionary.Add((PauseState)i, uiDoc);
            i++;
        }
    }

    private void Start() {
        GameEvents.OnUIOpen.AddListener(ShowUI);
        GameEvents.OnUIClose.AddListener(CloseUI);
    }

    private void ShowUI(PauseState state) {
        _uiDictionary[state].GetComponent<UIDocument>().rootVisualElement.style.display = DisplayStyle.Flex;
    }

    private void CloseUI(PauseState state) {
        _uiDictionary[state].GetComponent<UIDocument>().rootVisualElement.style.display = DisplayStyle.None;
        if (state == PauseState.InventoryMenu) {
            _uiDictionary[state].GetComponent<InventoryUI>().ClearSelectionOnClose();
        }
    }
    
    
}
