using Live2D.Cubism.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Hand : MonoBehaviour
{
    public CubismModel model;
    public bool clickSwitchHand;

    private bool isTouch;
    private bool isNotTouch = true;
    private bool isTouchAndMove;
    private bool isNotTouchAndMove = true;

    private void Update()
    {
        switch (gameObject.name)
        {
            case "BoobL_UI":
                if (isTouch || isTouchAndMove)
                {
                    model.Parameters[19].Value = 10f;
                }
                else if (isNotTouch && isNotTouchAndMove)
                {
                    model.Parameters[19].Value = 0f;
                }
                break;
            case "BoobR_UI":
                if (isTouch || isTouchAndMove)
                {
                    model.Parameters[20].Value = 10f;
                }
                else if (isNotTouch && isNotTouchAndMove)
                {
                    model.Parameters[20].Value = 0f;
                }
                break;
            case "Teasing_UI":
                if (isTouch || isTouchAndMove)
                {
                    model.Parameters[21].Value = 10f;
                }
                else if (isNotTouch && isNotTouchAndMove)
                {
                    model.Parameters[21].Value = 0f;
                }
                break;
            case "JerkOffHer_UI":
                if (isTouch || isTouchAndMove)
                {
                    model.Parameters[22].Value = 10f;
                }
                else if (isNotTouch && isNotTouchAndMove)
                {
                    model.Parameters[22].Value = 0f;
                }
                break;
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

    public void JerkOffHer()
    {
        clickSwitchHand = !clickSwitchHand;
    }

    private void UI_Control()
    {
        
    }
}
