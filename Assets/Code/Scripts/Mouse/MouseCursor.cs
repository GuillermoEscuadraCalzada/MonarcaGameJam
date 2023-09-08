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
            Vector2 mousePosition = Input.mousePosition;
            mousePosition = cam.ScreenToWorldPoint(mousePosition);
            transform.position = mousePosition;
        }
        
    }
}
