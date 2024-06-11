using UnityEngine;

namespace Objects {
    public class SaveStation : Interactable, IInteractableConstruction
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

        private void GetCurrentCam(GameObject cam) {
            _prevCamera = cam;
        }

        private void OnMouseDown() {
            if (_canFocusObject) {
                _canFocusObject = false;
                _prevCamera.SetActive(false);
                _areaCamera.SetActive(true);
                GameEvents.SwitchPause(GameState.SaveMenu);
            }
        }

        private void ReturnPrevCam(GameState state) {
            if (state == GameState.SaveMenu) {
                _canFocusObject = true;
                _prevCamera.SetActive(true);
                _areaCamera.SetActive(false); 
            }
        }
    }
}
