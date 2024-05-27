using UnityEngine;
using UnityEngine.AI;

public class MovementController : MonoBehaviour {
    [SerializeField]
    private NavMeshAgent _agent;

    private Camera _currentCam;

    private void Start() {
        GameEvents.OnCameraChange.AddListener(ChangeCamera);
    }

    private void ChangeCamera(GameObject cam) {
        _currentCam = cam.GetComponent<Camera>();
    }

    private void Update() {
        if (Input.GetMouseButton(0)) {
            var ray = _currentCam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit)) {
                _agent.SetDestination(hit.point);
            }
        }
    }
}