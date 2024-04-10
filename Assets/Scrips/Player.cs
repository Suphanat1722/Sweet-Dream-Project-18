using Live2D.Cubism.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CubismModel model;

    private bool isClick;

    private void Start()
    {
        model.Parts[3].Opacity = 0f;
    }

    private void LateUpdate()
    {
        if (isClick)
        {
            model.Parts[3].Opacity = 1f;
        }    
    }

    public void OpacityParts()
    {
        isClick = true;
    }
}
