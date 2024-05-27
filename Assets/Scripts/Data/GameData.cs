[System.Serializable]
public class GameData {
    public int level;
    public float[] position;
    public int state;

    public GameData(WorldState worldState) {
        level = worldState.Level;
        position = new float[3];

        position[0] = worldState.PlayerPos.transform.position.x;
        position[1] = worldState.PlayerPos.transform.position.y;
        position[2] = worldState.PlayerPos.transform.position.z;

        state = worldState.State;
    }
}