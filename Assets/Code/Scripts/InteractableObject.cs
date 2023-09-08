using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Code.Scripts
{
    public class InteractableObject : MonoBehaviour, IPointerEnterHandler
    {
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }
        
        public void OnPointerEnter(PointerEventData eventData)
        {
            print("Pointer entered");
        }
    }
}
