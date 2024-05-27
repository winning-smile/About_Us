using UnityEngine;

public class SaveStationController : MonoBehaviour
{
    private void OnMouseDown() {
        GameEvents.SwitchPause(1);
    }
}
