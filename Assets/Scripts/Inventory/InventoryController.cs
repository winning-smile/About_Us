using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InventoryController : MonoBehaviour {
    public readonly List<InventoryCell> _cells;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++) {
            _cells.Add(new InventoryCell());
        }
        
        GameEvents.OnItemPick.AddListener(PickItem);
    }

    private void PickItem(ScriptableObject item) {
        for (int i = 0; i < _cells.Count; i++) {
            if (_cells[i].IsEmpty()) {
                _cells[i].StoreItem(item);
                break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
