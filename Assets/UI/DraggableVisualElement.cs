using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

namespace UI {
    public class DraggableVisualElement : VisualElement {
        [UnityEngine.Scripting.Preserve]
        
        public new class UxmlFactory : UxmlFactory<DraggableVisualElement> { }
        

    }
}