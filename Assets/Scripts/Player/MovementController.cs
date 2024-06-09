using Objects;
using UnityEngine;
using UnityEngine.AI;

public class MovementController : MonoBehaviour {
    [SerializeField]
    private NavMeshAgent _agent;
    
    [SerializeField]
    private Transform _playerTransform;

    private Camera _currentCam;

    private void Start() {
        GameEvents.OnCameraChange.AddListener(ChangeCamera);
        GameEvents.OnDoorInteraction.AddListener(TeleportToPoint);
    }

    private void ChangeCamera(GameObject cam) {
        _currentCam = cam.GetComponent<Camera>();
    }
    
    private void TeleportToPoint(Transform teleportPoint) {
        _agent.Warp(teleportPoint.position);
    }


    private void Update() {
        if (Input.GetMouseButton(0)) {
            var ray = _currentCam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit)) {
                if (!hit.collider.GetComponent<Interactable>()) {
                    _agent.SetDestination(hit.point);
                }
            }
        }
    }
}