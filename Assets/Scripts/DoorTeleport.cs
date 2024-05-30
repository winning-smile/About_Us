using UnityEngine;

public class DoorTeleport : MonoBehaviour {
    [SerializeField]
    private Transform _teleportPoint;
    private void OnMouseDown() {
        GameEvents.TeleportToPoint(_teleportPoint);
    }
}
