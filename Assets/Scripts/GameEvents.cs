using UnityEngine;
using UnityEngine.Events;

public class GameEvents
{
    // коды Paused: 1 - пауза через esc; 2 - вход в SaveMenu
    public static UnityEvent<GameObject> OnCameraChange = new UnityEvent<GameObject>();
    public static UnityEvent<Item> OnItemPick = new UnityEvent<Item>();
    public static UnityEvent<Item> OnItemPicked = new UnityEvent<Item>();
    public static UnityEvent<Transform> OnDoorInteraction = new UnityEvent<Transform>();

    public static UnityEvent<int> OnUIOpen = new UnityEvent<int>();
    public static UnityEvent<int> OnUIClose= new UnityEvent<int>();
    
    private static bool _isPaused;
    
    public static void SwitchPause(int mode) {
        _isPaused = !_isPaused;

        if (_isPaused) {
            OnUIOpen.Invoke(mode);
        } else {
            OnUIClose.Invoke(mode);
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
