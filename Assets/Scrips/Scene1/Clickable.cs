using Live2D.Cubism.Core;
using Microsoft.Unity.VisualStudio.Editor;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Clickable : MonoBehaviour,IDragHandler, IEndDragHandler
{
    public bool isClick;
  
    private Vector3 gameObjStartPos;
    private RectTransform rectTransform;


    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        gameObjStartPos = rectTransform.anchoredPosition;
    }



    public void OnDrag(PointerEventData eventData)
    {
        isClick = true;
        rectTransform.anchoredPosition += eventData.delta;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        isClick = false;
        rectTransform.anchoredPosition = gameObjStartPos;
    }
}

