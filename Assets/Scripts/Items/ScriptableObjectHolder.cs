using System;
using Unity.VisualScripting;
using UnityEngine;

public class ScriptableObjectHolder : IInteractable {
    public ScriptableObject _scriptableObject;

    protected override void Start() {
    }

    private void OnMouseDown() {
        GameEvents.PickItem(_scriptableObject);
        Destroy(this.GameObject());
    }
}