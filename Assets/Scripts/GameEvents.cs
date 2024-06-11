using UnityEngine;
using UnityEngine.Events;

public class GameEvents
{
    public static UnityEvent<GameObject> OnCameraChange = new UnityEvent<GameObject>();
    public static UnityEvent<Item> OnItemPick = new UnityEvent<Item>();
    public static UnityEvent<Item> OnItemPicked = new UnityEvent<Item>();
    public static UnityEvent<Transform> OnDoorInteraction = new UnityEvent<Transform>();

    public static UnityEvent<GameState> OnUIOpen = new UnityEvent<GameState>();
    public static UnityEvent<GameState> OnUIClose= new UnityEvent<GameState>();
    
    private static bool _isPaused;
    
    public static void SwitchPause(GameState state) {
        _isPaused = !_isPaused;

        if (_isPaused) {
            OnUIOpen.Invoke(state);
        } else {
            OnUIClose.Invoke(state);
        }
    }

    public static void TeleportToPoint(Transform teleportPoint) {
        OnDoorInteraction.Invoke(teleportPoint);
    }
    
    public static void ChangeCamera(GameObject cam) {
        OnCameraChange.Invoke(cam);
    }

    public static void PickItem(Item item) {
        OnItemPick.Invoke(item);
    }
    
    public static void AddItemToInventoryUI(Item item) {
        OnItemPicked.Invoke(item);
    }
}
