using System;
using UnityEngine;

[CreateAssetMenu(fileName = "ActiveItem", menuName = "ScriptableObjects/ActiveItem")]
[Serializable]
public class Item : ScriptableObject {
    public int ItemId;
    public string ItemName;
    public string ItemInfo;
    public GameObject ItemModel;
}
