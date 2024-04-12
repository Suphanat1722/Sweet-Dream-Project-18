using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class MouseClickOn : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public static string uiName;


    public void OnPointerDown(PointerEventData eventData)
    {
        uiName = gameObject.name;       
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        uiName = "";      
    }
}
