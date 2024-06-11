using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

namespace Inventory {
    public class ItemInspectionController : MonoBehaviour {
        private Transform itemPrefab;

        public void CreateInspectionItem(Transform prefab) {
            if (itemPrefab != null) {
                Destroy(itemPrefab.gameObject);
            }

            itemPrefab = Instantiate(prefab, new Vector3(-25, -100, 20), Quaternion.identity);
        }

        public void DestroyInspectionItem() {
            if (itemPrefab) {
                Destroy(itemPrefab.gameObject);
            }
        }

        public void RotateInspectionItem(PointerMoveEvent eventData) {
            itemPrefab.eulerAngles += new Vector3(eventData.deltaPosition.y, -eventData.deltaPosition.x);
        }
    }
}