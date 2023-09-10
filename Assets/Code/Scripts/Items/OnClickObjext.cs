using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnClickObjext : MonoBehaviour
{
    public UnityEvent OnClick;
    public UnityEvent OnFirstClick;
    bool hasClicked = false;

    private void OnMouseDown()
    {
        OnFirstClick.Invoke();
        hasClicked = true;
        OnClick.Invoke();
    }
}
