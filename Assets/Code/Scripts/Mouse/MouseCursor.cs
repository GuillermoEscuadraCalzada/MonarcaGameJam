using UnityEngine;

namespace Mouse{
    public class MouseCursor : MonoBehaviour{
        private Camera cam;
        public static Vector2 MousePosition;
        public static Vector2 MousePositionWP;
        private void Start() {
            Cursor.visible = false;
            cam = Camera.main;
            Cursor.lockState = CursorLockMode.Confined;
        }

        private void Update() {
            MousePosition = Input.mousePosition;
            MousePositionWP = cam.ScreenToWorldPoint(MousePosition);
            MoveToMousePosition();
        }

        private void MoveToMousePosition() {
            if (GamePause.isGamePaused){
                ShowCursor();
                return;
            }
            transform.position = MousePositionWP;
        }

        public void ShowCursor() {
            Cursor.visible = true;

        }
    }
}
