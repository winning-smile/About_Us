using UnityEngine;

public class InventoryUIController : MonoBehaviour
{
    public InventoryUI _InventoryUI;

    private void OnValidate() {
        if (!_InventoryUI) {
            _InventoryUI = GetComponentInChildren<InventoryUI>();
        }
    }
}
