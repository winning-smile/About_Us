using UnityEngine;

public class WorldState: MonoBehaviour {
    [SerializeField]
    private GameObject _player;
    
    public int Level = 1;
    public Transform PlayerPos;
    public int State = 0;

    public void SaveData() {
        PlayerPos = _player.transform;
        
        SaveLoadSystem.SaveData(this);
    }

    public void LoadPlayer() {
        GameData data = SaveLoadSystem.LoadData();

        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        
        Level = data.level;
        PlayerPos.position = position;
        State = data.state;
    }
}
