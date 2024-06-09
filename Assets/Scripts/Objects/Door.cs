using UnityEngine;

namespace Objects {
    public class Door : Interactable {
        [SerializeField]
        private Transform _teleportPoint;
        private void OnMouseDown() {
            GameEvents.TeleportToPoint(_teleportPoint);
        }
    }
}
