using System;
using System.Collections;
using System.Collections.Generic;
using Inputs;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseCursor : MonoBehaviour, PlayerInputs.IMyActionMapActions
{
    private PlayerInputs.MyActionMapActions _myActionMapActions;

    private void Awake()
    {
        _myActionMapActions.Enable();
        _myActionMapActions.AddCallbacks(this);
    }

    private void OnEnable()
    {
    }

    private void OnDisable()
    {
        _myActionMapActions.Disable();
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
