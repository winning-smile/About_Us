using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class UIManager : MonoBehaviour {
    [SerializeField]
    private GameObject[] _uiElements;
    private Dictionary<int, GameObject> _uiDictionary = new();

    private void Awake() {
        var i = 0;
        foreach (var uiDoc in _uiElements) {
            _uiDictionary.Add(i, uiDoc);
            i++;
        }
    }

    private void Start() {
        GameEvents.OnUIOpen.AddListener(ShowUI);
        GameEvents.OnUIClose.AddListener(CloseUI);
    }

    private void ShowUI(int mode) {
        _uiDictionary[mode].GetComponent<UIDocument>().rootVisualElement.style.display = DisplayStyle.Flex;
    }

    private void CloseUI(int mode) {
        _uiDictionary[mode].GetComponent<UIDocument>().rootVisualElement.style.display = DisplayStyle.None;
    }
    
    
}
