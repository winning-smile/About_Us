using UnityEngine;
using UnityEngine.Events;

public class GameEvents
{
    // коды Paused: 1 - пауза через esc; 2 - вход в SaveMenu
    public static UnityEvent<GameObject> OnCameraChange = new UnityEvent<GameObject>();
    public static UnityEvent<ScriptableObject> OnItemPick = new UnityEvent<ScriptableObject>();
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
        Debug.Log("Camera is changed");
        OnCameraChange.Invoke(cam);
    }

    public static void PickItem(ScriptableObject item) {
        OnItemPick.Invoke(item);
    }
}
