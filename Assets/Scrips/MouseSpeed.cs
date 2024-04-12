using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseSpeed : MonoBehaviour
{
    public float mouseSpeedThreshold;

    private float mouseX;
    private float mouseY;

    public static float currentMouseSpeed;
    public static int mouseSpeedAvg;

    void Update()
    {
        CalMouseSpeed();
    }

    private void CalMouseSpeed()
    {
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");
        currentMouseSpeed = Mathf.Sqrt(mouseX * mouseX + mouseY * mouseY); // คำนวณความเร็วของเมาส์

        currentMouseSpeed *= Time.deltaTime;
        currentMouseSpeed *= mouseSpeedThreshold; //mouseSpeedThreshold = 5000

        if (MouseSpeed.currentMouseSpeed <= 1 && MouseSpeed.currentMouseSpeed < 2)
        {
            mouseSpeedAvg = 1;
        }
        else if (MouseSpeed.currentMouseSpeed >= 2 && MouseSpeed.currentMouseSpeed < 3)
        {
            mouseSpeedAvg = 2;
        }
        else if (MouseSpeed.currentMouseSpeed >= 3)
        {
            mouseSpeedAvg = 5;
        }
    }
}
