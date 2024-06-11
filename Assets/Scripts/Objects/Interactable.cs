using System.Collections;
using UnityEngine;

namespace Objects {
    public abstract class Interactable : MonoBehaviour {
        private const float OUTLINE_MIN_WIDTH = 0f;
        private const float OUTLINE_MAX_WIDTH = 7f;
        private const float OUTLINE_DRAW_THICK = 1f;
        private Outline _outline;
        private bool _isActive = true;

        private void OnValidate() {
            if (!_outline) {
                _outline = GetComponent<Outline>();
            }
        }

        protected virtual void Start() {
            GameEvents.OnUIOpen.AddListener(ChangeOutlineState);
            GameEvents.OnUIClose.AddListener(ChangeOutlineState);
        }

        private void ChangeOutlineState(GameState state) {
            _outline.enabled = !_outline.enabled;
            _isActive = !_isActive;
        }

        private void OnMouseEnter() {
            if (_isActive) {
                StartCoroutine(EnableOutline());
            }
        }

        private void OnMouseExit() {
            if (_isActive) {
                StopCoroutine(EnableOutline());
                _outline.enabled = false;
                _outline.OutlineWidth = OUTLINE_MIN_WIDTH;
            }
        }

        private IEnumerator EnableOutline() {
            _outline.enabled = true;

            while (_outline.OutlineWidth < OUTLINE_MAX_WIDTH) {
                _outline.OutlineWidth += OUTLINE_DRAW_THICK;
                yield return new WaitForSeconds(0.1f);
            }

            yield return null;
        }
    }
}