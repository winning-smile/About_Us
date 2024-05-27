using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveLoadSystem {
    public static void SaveData(WorldState gameData) {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/save_1.melxy";
        FileStream fileStream = new FileStream(path, FileMode.Create);

        GameData data = new GameData(gameData);

        formatter.Serialize(fileStream, data);
        fileStream.Close();
    }

    public static GameData LoadData() {
        string path = Application.persistentDataPath + "/save_1.melxy";
        if (File.Exists(path)) {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fileStream = new FileStream(path, FileMode.Open);

            GameData data = formatter.Deserialize(fileStream) as GameData;
            fileStream.Close();

            return data;
        } else {
            Debug.Log("пошел нафик");

            return null;
        }
    }
}