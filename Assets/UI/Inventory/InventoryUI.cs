using UnityEngine.UIElements;

public class InventoryUI : UIElement
{
    private void OnEnable() {
        _root.style.display = DisplayStyle.None;
    }
}
