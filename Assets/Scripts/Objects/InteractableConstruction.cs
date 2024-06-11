using UnityEngine;

namespace Objects {
    public abstract class InteractableConstruction : Interactable {
        protected abstract void GetCurrentCam(GameObject cam);

        protected abstract void OnMouseDown();
    }
}