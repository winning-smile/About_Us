using UnityEngine;

namespace Objects {
    public class InteractableItem : Interactable {
        [SerializeField]
        private Item _item;

        private void OnMouseDown() {
            GameEvents.PickItem(_item);
            Destroy(this.gameObject);
        }
    }
}