public class InventoryCell {
    private Item _slotItem;
    private bool _isEmpty;

    public InventoryCell(bool isEmpty = true, Item slotItem = null) {
        _slotItem = slotItem;
        _isEmpty = isEmpty;
    }

    public bool IsEmpty() {
        return _isEmpty;
    }

    public void StoreItem(Item item) {
        _slotItem = item;
    }
}