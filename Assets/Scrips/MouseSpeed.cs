using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MouseSpeed : MonoBehaviour
{
    public float mouseSpeedThreshold;
    public Slider slider;

    private float mouseX;
    private float mouseY;

    public static float currentMouseSpeed;

    void Update()
    {
        CalMouseSpeed();

        if (currentMouseSpeed > 1f && Input.GetMouseButton(0))
        {
            slider.value += currentMouseSpeed * Time.deltaTime;
        }
    }

    private void CalMouseSpeed()
    {
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");
        currentMouseSpeed = Mathf.Sqrt(mouseX * mouseX + mouseY * mouseY); // คำนวณความเร็วของเมาส์

        currentMouseSpeed *= Time.deltaTime;
        currentMouseSpeed *= mouseSpeedThreshold; //mouseSpeedThreshold = 10000
    }
}
