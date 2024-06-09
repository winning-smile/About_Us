using UnityEngine;

public class SpawnPlayer : MonoBehaviour {
    [SerializeField]
    private Transform _spawnPoint;

    [SerializeField]
    private WorldState _worldState;

    private void Start() {
        if (_worldState.PlayerPos) {
            transform.position = _worldState.PlayerPos.position;
        } else {
            transform.position = _spawnPoint.position;
        }
    }
}