using System;
using System.Buffers;
using UnityEngine;
using UnityEngine.UIElements;

namespace Inventory {
    public class ItemInspectionController : MonoBehaviour {
        [SerializeField]
        private GameObject _itemInspectCamera;

        private Transform itemPrefab;
        private float distance = 0f;

        public void CreateInspectionItem(Transform prefab) {
            if (itemPrefab != null) {
                Destroy(itemPrefab.gameObject);
            }

            itemPrefab = Instantiate(prefab, new Vector3(-20, -100, 30), Quaternion.identity);
        }

        public void DestroyInspectionItem() {
            if (itemPrefab) {
                Destroy(itemPrefab.gameObject);
            }
        }

        public void RotateInspectionItem(PointerMoveEvent eventData) {
            var position = itemPrefab.position;
            
            itemPrefab.RotateAround(position, _itemInspectCamera.transform.up, -eventData.deltaPosition.x);
            itemPrefab.RotateAround(position, _itemInspectCamera.transform.right, -eventData.deltaPosition.y);
        }

        public void ZoomInspectionItem(WheelEvent eventData) {
            var movePos = new Vector3(0, 0, -eventData.delta.y / 3);
            itemPrefab.Translate(movePos, _itemInspectCamera.transform);
            var position = itemPrefab.position;
            position = new Vector3(position.x, position.y, Mathf.Clamp(position.z, 25, 35));
            itemPrefab.position = position;
        }
    }
}