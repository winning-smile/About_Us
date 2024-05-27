using UnityEngine;

public class CameraSwitchController : MonoBehaviour {
    private ICameraHolder _currentCameraHolder;

    private void OnTriggerEnter(Collider other) {
        if (other.GetComponent<ICameraHolder>()) {
            if (!_currentCameraHolder) {
                _currentCameraHolder = other.GetComponent<ICameraHolder>();
                GameEvents.ChangeCamera(_currentCameraHolder.ReturnCamera());
            }

            _currentCameraHolder.TurnCameraOff();
            _currentCameraHolder = other.GetComponent<ICameraHolder>();
            _currentCameraHolder.TurnCameraOn();
            GameEvents.ChangeCamera(_currentCameraHolder.ReturnCamera());
        }
    }
}