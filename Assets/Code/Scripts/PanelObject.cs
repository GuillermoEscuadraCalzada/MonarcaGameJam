using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Code.Scripts;

public class PanelObject : MonoBehaviour
{
    public bool canMove=true;
    public GameObject panel;
    public InteractableObject interactable; 
    public LangID lang;

    public void OpenPanel(string id, InteractableObject obj)
    {
        canMove = false;
        interactable = obj;
        lang.id = id;
        panel.SetActive(true);
    }

    public void ClosePanel()
    {
        panel.SetActive(false);
        canMove = true;
        interactable.hasPanel = false;
    }
    
}
