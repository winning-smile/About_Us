using UnityEngine;
using UnityEngine.Rendering;

public class CameraController : MonoBehaviour {
    private const float CAMERA_SENS = 100.0f;

    [SerializeField]
    Transform _playerTransform;

    private float _currentRotation;

    private void Awake() {
        Cursor.visible = true;
    }

    private void Update() {
        var mouseX = Input.GetAxis("Mouse X") * CAMERA_SENS * Time.deltaTime;
        _playerTransform.Rotate(Vector3.up * mouseX);
    }
}