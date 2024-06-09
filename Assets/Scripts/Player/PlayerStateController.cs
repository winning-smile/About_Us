using UnityEngine;

public class PlayerStateController : MonoBehaviour {
    [SerializeField]
    private GameObject _player;

    private MovementController _playerMovementController;
    private void Start() {
        _playerMovementController = _player.GetComponent<MovementController>();
        GameEvents.OnUIOpen.AddListener(SetStaticState);
        GameEvents.OnUIClose.AddListener(SetActiveState);
    }

    private void SetStaticState(int mode) {
        _playerMovementController.enabled = false;
    }

    private void SetActiveState(int mode) {
        _playerMovementController.enabled = true;
        
    }
}
