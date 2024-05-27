using UnityEngine;

public class PlayerStateController : MonoBehaviour {
    [SerializeField]
    private GameObject _player;

    private MovementController _playerMovementController;
    private void Start() {
        _playerMovementController = _player.GetComponent<MovementController>();
        GameEvents.OnActiveGameEvent.AddListener(SetStaticState);
        GameEvents.OnPassiveGameEvent.AddListener(SetActiveState);
    }

    private void SetStaticState() {
        _playerMovementController.enabled = false;
        //_player.gameObject.GetComponentInChildren<MeshRenderer>().enabled = false;
    }

    private void SetActiveState() {
        _playerMovementController.enabled = true;
        
    }
}
