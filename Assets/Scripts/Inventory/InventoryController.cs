using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour {
    public List<InventoryCell> _cells = new List<InventoryCell>();
    
    void Start()
    {
        for (int i = 0; i < 10; i++) {
            _cells.Add(new InventoryCell());
        }
        
        GameEvents.OnItemPick.AddListener(PickItem);
    }

    private void PickItem(Item item) {
        for (int i = 0; i < _cells.Count; i++) {
            if (_cells[i].IsEmpty()) {
                _cells[i].StoreItem(item);
                break;
            }
        }
        
        GameEvents.AddItemToInventoryUI(item);
    }
}
