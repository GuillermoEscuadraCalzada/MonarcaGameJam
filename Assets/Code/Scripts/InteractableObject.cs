using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Code.Scripts
{
    public class InteractableObject : MonoBehaviour
    {
        [Header("General")]
        [SerializeField] InventoryClass inventoryClass;
        PanelObject panel;
        public bool hasPanel;
        [SerializeField] string idPanel;
        
        GameObject UIElement;
        Vector3 originalPos;

        [Header("Drag and Drop")]
        [SerializeField] UnityEvent onCorrectDropActions;
        [SerializeField] string correctID;
        [SerializeField] string incorrectID;
        Sprite sprite;
        private Vector3 mOffset;

        private void Start()
        {
            if (panel == null)
                panel = GameObject.Find("Panel Description").GetComponent<PanelObject>();
            if (UIElement == null)
                UIElement = GameObject.Find("UI Element");
            sprite = GetComponent<SpriteRenderer>().sprite;
            originalPos = this.transform.position;
        }

        private void OnMouseDown()
        {
            if (panel.canMove)
            {
                if (hasPanel)
                {
                    panel.OpenPanel(idPanel, this);
                }

                else
                {
                    mOffset = gameObject.transform.position - GetMouseWorldPosition();
                    this.GetComponent<SpriteRenderer>().enabled = false;
                    UIElement.GetComponent<Image>().sprite = sprite;
                    UIElement.GetComponent<Image>().enabled = true;
                }
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
            if (!hasPanel && panel.canMove)
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
            if (panel.canMove)
            {
                UIElement.GetComponent<CircleCollider2D>().enabled = true;
                RaycastHit2D[] hit = Physics2D.CircleCastAll(UIElement.transform.position, UIElement.GetComponent<CircleCollider2D>().radius, Vector2.zero);
                foreach (RaycastHit2D h in hit)
                {
                    if (h.transform.GetComponent<InventoryItem>())
                    {
                        if (CheckCollision(h.transform.GetComponent<InventoryItem>()))
                        {
                            AproveItem();
                        }
                        ReturnItem();
                        return;
                    }
                }

                ReturnItem();
            }
        }

        private bool CheckCollision(InventoryItem item)
        {
            if (item.inventoryClass == inventoryClass)
            {
                return true;
            }
            return false;
        }

        private void AproveItem()
        {
            onCorrectDropActions.Invoke();
            UIElement.GetComponent<Image>().enabled = false;
            Destroy(this.gameObject);
            UIElement.GetComponent<CircleCollider2D>().enabled = false;
        }

        private void ReturnItem()
        {
            UIElement.GetComponent<CircleCollider2D>().enabled = false;
            UIElement.GetComponent<Image>().enabled = false;
            UIElement.transform.position = Vector3.zero;
            this.transform.position = originalPos;
            this.GetComponent<SpriteRenderer>().enabled = true;
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.yellow;
        }
    }
}
