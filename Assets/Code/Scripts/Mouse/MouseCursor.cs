using UnityEngine;

namespace Mouse{
    public class MouseCursor : MonoBehaviour{
        private Camera cam;
        private void Start() {
            Cursor.visible = false;
            cam = Camera.main;
            Cursor.lockState = CursorLockMode.Confined;
        }

        private void Update() {
            MoveToMousePosition();
        }

        private void MoveToMousePosition() {
            if (GamePause.isGamePaused){
                ShowCursor();
                return;
            }
            Vector2 mousePosition = Input.mousePosition;
            mousePosition = cam.ScreenToWorldPoint(mousePosition);
            transform.position = mousePosition;
        }

        public void ShowCursor() {
            Cursor.visible = true;

        }
    }
}
