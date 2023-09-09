using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Code.Scripts
{
    public class InteractableObject : MonoBehaviour
    {
        [Header("General")]
        [SerializeField] InventoryClass inventoryClass;
        [SerializeField] bool hasPanel;
        Canvas canvas;
        GameObject panel;
        GameObject UIElement;

        [Header ("Drag and Drop")]
        Sprite sprite;
        private Vector3 mOffset;

        private void Start()
        {
            if (panel == null)
                panel = GameObject.Find("Panel Description");
            if (UIElement == null)
                UIElement = GameObject.Find("UI Element");
            sprite = GetComponent<SpriteRenderer>().sprite;
        }

        private void OnMouseDown()
        {
            if (hasPanel)
            {
                panel.SetActive(true);
            }

            else
            {
                mOffset = gameObject.transform.position - GetMouseWorldPosition();
                this.GetComponent<SpriteRenderer>().enabled = false;
                UIElement.GetComponent<Image>().sprite = sprite;
                UIElement.SetActive(true);
            }
        }

        private Vector3 GetMouseWorldPosition()
        {
            Vector3 mousePoint=Input.mousePosition;
            mousePoint.z = 0;
            return Camera.main.ScreenToWorldPoint(mousePoint);
        }

        private void OnMouseDrag()
        {

            if (!hasPanel)
            {
                transform.position = GetMouseWorldPosition() + mOffset;
                
                Vector3 mousePos=Input.mousePosition;
                float x = mousePos.x;
                float y = mousePos.y;
                UIElement.transform.position = new Vector3(x, y, 0);
            }
        }

        private void OnMouseUp()
        {
            Debug.Log("MouseUp");

            //RaycastHit2D hit = Physics2D.CircleCast(UIElement.transform.position + (Vector3)deltaPos, radius, UIElement.transform.right, distance);
            RaycastHit2D[] hit = Physics2D.CircleCastAll(UIElement.transform.position, UIElement.GetComponent<CircleCollider2D>().radius, Vector2.zero);
            foreach (RaycastHit2D h in hit)
            {
                if(h.transform.GetComponent<InventoryItem>())
                {
                    
                }
            }
        }

        private void CheckCollision(InventoryItem item)
        {
            if (item.inventoryClass == inventoryClass)
            {

            }
        }

        private void ReturnItem()
        {
            UIElement.SetActive(false);
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.yellow;
        }
    }
}
