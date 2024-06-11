using UnityEngine;

namespace Objects {
    public class SaveStation : InteractableConstruction
    {
        private GameObject _areaCamera;
        private GameObject _prevCamera;
        private bool _canFocusObject = true;
        
        protected override void Start() {
            base.Start();
            _areaCamera = GetComponent<ICameraHolder>().ReturnCamera();
            GameEvents.OnCameraChange.AddListener(GetCurrentCam);
            GameEvents.OnUIClose.AddListener(ReturnPrevCam);
        }

        protected override void GetCurrentCam(GameObject cam) {
            _prevCamera = cam;
        }

        protected override void OnMouseDown() {
            if (_canFocusObject) {
                _canFocusObject = false;
                _prevCamera.SetActive(false);
                _areaCamera.SetActive(true);
                GameEvents.SwitchPause(PauseState.SaveMenu);
            }
        }

        private void ReturnPrevCam(PauseState state) {
            if (state == PauseState.SaveMenu) {
                _canFocusObject = true;
                _prevCamera.SetActive(true);
                _areaCamera.SetActive(false); 
            }
        }
    }
}
