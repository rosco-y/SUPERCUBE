using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class cCanvasClick : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
            leftClick();
        else if (eventData.button == PointerEventData.InputButton.Right)
            rightClick();
    }

    private void rightClick()
    {
        Debug.Log("RightClick");
    }

    private void leftClick()
    {
        Debug.Log("LeftClick");
    }

}
