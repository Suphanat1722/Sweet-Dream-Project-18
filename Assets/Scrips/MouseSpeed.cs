using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MouseSpeed : MonoBehaviour
{
    public float mouseSpeedThreshold;
    public Slider slider;

    public TextMeshProUGUI speed_text;
    public TextMeshProUGUI textDebug;

    private float mouseX;
    private float mouseY;
    private float currentMouseSpeed;

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

        textDebug.text = currentMouseSpeed.ToString();

        if (currentMouseSpeed >= 1 && currentMouseSpeed < 2)
        {
            speed_text.text = "1";
        }
        else if (currentMouseSpeed >= 2 && currentMouseSpeed < 3)
        {
            speed_text.text = "2";
        }
        else if (currentMouseSpeed >= 3 && currentMouseSpeed < 4)
        {
            speed_text.text = "5";
        }
    }
}
