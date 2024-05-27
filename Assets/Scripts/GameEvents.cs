using UnityEngine;
using UnityEngine.Events;

public class GameEvents
{
    // коды Paused: 1 - пауза через esc; 2 - вход в SaveMenu
    public static UnityEvent<GameObject> OnCameraChange = new UnityEvent<GameObject>();
    public static UnityEvent OnActiveGameEvent = new UnityEvent();
    public static UnityEvent OnPassiveGameEvent = new UnityEvent();
    public static UnityEvent Paused = new UnityEvent();
    public static UnityEvent Unpaused = new UnityEvent();

    public static UnityEvent<int> OnUIOpen = new UnityEvent<int>();
    public static UnityEvent<int> OnUIClose= new UnityEvent<int>();
    
    private static bool _isPaused;
    
    public static void SwitchPause(int mode) {
        _isPaused = !_isPaused;

        if (_isPaused) {
            OnUIOpen.Invoke(mode);
        } else {
            OnUIClose.Invoke(mode);;
        }
    }
    
    public static void ChangeCamera(GameObject cam) {
        Debug.Log("Camera is changed");
        OnCameraChange.Invoke(cam);
    }
    
    public static void SetPassiveState() {
        OnActiveGameEvent.Invoke();
    }
    
    public static void SetActiveState() {
        OnPassiveGameEvent.Invoke();
    }
}
