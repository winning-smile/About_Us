using UnityEngine;

public class InteractableCameraSwitcher : IInteractable {
    private GameObject _areaCamera;
    private GameObject _prevCamera;
    private bool nasral = true;

    protected override void Start() {
        base.Start();
        _areaCamera = GetComponent<ICameraHolder>().ReturnCamera();
        GameEvents.OnCameraChange.AddListener(GetCurrentCam);
    }

    private void GetCurrentCam(GameObject cam) {
        _prevCamera = cam;
    }

    private void OnMouseDown() {
        if (nasral) {
            nasral = !nasral;
            _prevCamera.SetActive(false);
            _areaCamera.SetActive(true);
            GameEvents.SetPassiveState();
        } else if (Input.GetMouseButton(1)) {
            _areaCamera.SetActive(false);
            _prevCamera.SetActive(true);
            GameEvents.SetActiveState();
            nasral = !nasral;
        }
    }
}