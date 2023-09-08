using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseCursor : MonoBehaviour
{

    private void Awake()
    {
    }

    private void OnEnable()
    {
    }

    private void OnDisable()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnLeftClick(InputAction.CallbackContext context)
    {
    }

    public void OnMouseAxis(InputAction.CallbackContext context)
    {
        Vector2 MousePos = context.ReadValue<Vector2>();
        MousePos = Camera.main.ScreenToWorldPoint(MousePos);
        Debug.Log(MousePos);
        
    }
}
