using UnityEngine;

public class InventoryUIController : MonoBehaviour
{
    public InventoryUI _InventoryUI;

    [SerializeField]
    private InventoryController _inventoryController;

    private void Start() {
        GameEvents.OnItemPicked.AddListener(AddItemToInventoryUI);
    }

    private void AddItemToInventoryUI(Item item) {
        _InventoryUI.AddItemToInventoryUI(item);
    }
}
