using UnityEngine;

namespace Inventory {
    public class ItemInspectionController : MonoBehaviour {
        private Transform itemPrefab;

        public void CreateInspectionItem(Transform prefab) {
            if (itemPrefab != null) {
                Destroy(itemPrefab.gameObject);
            }

            itemPrefab = Instantiate(prefab, new Vector3(-25, -100, 20), Quaternion.Euler(10f, 20f, -20f));
        }

        public void DestroyInspectionItem() {
            if (itemPrefab) {
                Destroy(itemPrefab.gameObject);
            }
        }
    }
}