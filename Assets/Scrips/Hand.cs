using Live2D.Cubism.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Hand : MonoBehaviour
{
    public CubismModel model;

    private bool isTouch;
    private bool isNotTouch = true;
    private bool isTouchAndMove;
    private bool isNotTouchAndMove = true;

    public bool isHandBoobsL;
    public bool isHandBoobsR;
    private bool isHandTeasing;
    private bool isHandJerkOffHer;


    private void Update()
    {
        switch (gameObject.name)
        {
            case "BoobL_UI":
                if (isTouch || isTouchAndMove)
                {
                    isHandBoobsL = true;                   
                }
                else if (isNotTouch && isNotTouchAndMove)
                {
                    isHandBoobsL = false;
                }
                break;
            case "BoobR_UI":
                if (isTouch || isTouchAndMove)
                {
                    isHandBoobsR = true;
                }
                else if (isNotTouch && isNotTouchAndMove)
                {
                    isHandBoobsR = false;
                }
                break;
            case "Teasing_UI":
                if (isTouch || isTouchAndMove)
                {
                    isHandTeasing = true;
                    
                }
                else if (isNotTouch && isNotTouchAndMove)
                {
                    isHandTeasing = false;
                }
                break;
            case "JerkOffHer_UI":
                if (isTouch || isTouchAndMove)
                {
                    isHandJerkOffHer = true;         
                }
                else if (isNotTouch && isNotTouchAndMove)
                {
                    isHandJerkOffHer = false;
                }
                break;
        }
    }

    private void LateUpdate()
    {
        if (isHandBoobsL)
        {
            model.Parameters[19].Value = 10f;
        }   
        if (isHandBoobsR)
        {
            model.Parameters[20].Value = 10f;
        }
        if (isHandTeasing)
        {
            model.Parameters[21].Value = 10f;
        }
        if (isHandJerkOffHer)
        {
            model.Parameters[22].Value = 10f;
        }
    }

    public void Touch()
    {
        isTouch = true;
        isNotTouch = false;
    }
    public void NotTouch()
    {
        isNotTouch = true;
        isTouch = false;
    }

    public void TouchAndMove()
    {
        isTouchAndMove = true;
        isNotTouchAndMove = false;
    }
    public void NotTouchAndMove()
    {
        isTouchAndMove = false;
        isNotTouchAndMove = true;
    }
}
