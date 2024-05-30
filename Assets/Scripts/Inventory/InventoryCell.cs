using UnityEngine;

public class InventoryCell {
    private ScriptableObject _slotItem;
    private bool _isEmpty;

    public InventoryCell(bool isEmpty = true, ScriptableObject slotItem = null) {
        _slotItem = slotItem;
        _isEmpty = isEmpty;
    }

    public ScriptableObject GetItem() {
        return _slotItem;
    }

    public bool IsEmpty() {
        return _isEmpty;
    }

    public void StoreItem(ScriptableObject item) {
        _slotItem = item;
    }
}