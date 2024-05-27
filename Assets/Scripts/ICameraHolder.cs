using UnityEngine;

public class ICameraHolder : MonoBehaviour {
    [SerializeField]
    private GameObject _areaCamera;

    public void TurnCameraOn() {
        _areaCamera.SetActive(true);
    }

    public void TurnCameraOff() {
        _areaCamera.SetActive(false);
    }

    public GameObject ReturnCamera() {
        return _areaCamera;
    }
}