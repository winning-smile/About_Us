using System;
using UnityEngine;

[CreateAssetMenu(fileName = "ActiveItem", menuName = "ScriptableObjects/ActiveItem")]
[Serializable]
public class Item : ScriptableObject
{
    [SerializeField] public int ItemId { get; set; }
    [SerializeField] public string ItemName { get; private set; }
    [SerializeField] public string ItemInfo { get; private set; }
    [SerializeField] public bool IsStackable { get; private set; }
    [SerializeField] public GameObject ItemModel { get; private set; }
    [SerializeField] public Sprite ItemImage { get; private set; }
}
