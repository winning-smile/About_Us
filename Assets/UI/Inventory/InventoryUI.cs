using System.Collections.Generic;
using System.Linq;
using Inventory;
using UnityEngine;
using UnityEngine.UIElements;

public class InventoryUI : UIElement {
    [SerializeField]
    private ItemInspectionController _itemInspectionController;
    public VisualTreeAsset itemsListTemplate;
    private ListView _itemsListView;
    private VisualElement _itemInspectionView;
    private List<Item> _itemList;
    
    private void OnEnable() {
        _root.style.display = DisplayStyle.None;
        _itemsListView = _root.Q<ListView>("inventoryView");
        _itemInspectionView = _root.Q<VisualElement>("ItemInspectionWindow");
        _itemList = new List<Item>();
    }

    public void AddItemToInventoryUI(Item item) {
        _itemList.Add(item);
        
        _itemsListView.makeItem = () =>
        {
            return itemsListTemplate.Instantiate();
        };
        _itemsListView.bindItem = (_item, _index) =>
        {
            _item.Q<Label>("item_name").text = item.ItemName;
            _item.Q<VisualElement>("item_image").style.backgroundImage = item.ItemSprite.texture;
        };
        _itemsListView.itemsSource = _itemList;
        _itemsListView.selectionType = SelectionType.Single;
        _itemsListView.selectionChanged += FocusItem;
        _itemsListView.ClearSelection();
        _itemsListView.Rebuild();
    }

    public void ClearSelectionOnClose() {
        _itemsListView.ClearSelection();
        _itemInspectionController.DestroyInspectionItem();
    }
    
    private void FocusItem(IEnumerable<object> obj) {
        if (obj.Any()) {
            var item = obj.First() as Item;
            Debug.Log($"{item.ItemName}"); 
            _itemInspectionController.CreateInspectionItem(item.prefab);
        }
    }
}
