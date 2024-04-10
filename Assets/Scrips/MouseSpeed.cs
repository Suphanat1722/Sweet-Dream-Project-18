using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MouseSpeed : MonoBehaviour
{
    public float mouseSpeedThreshold;

    public TextMeshProUGUI speed_text;
    public TextMeshProUGUI textDebug;

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        float mouseSpeed = Mathf.Sqrt(mouseX * mouseX + mouseY * mouseY); // คำนวณความเร็วของเมาส์

        mouseSpeed *= Time.deltaTime;
        mouseSpeed *= mouseSpeedThreshold;

        textDebug.text = mouseSpeed.ToString();

        if (mouseSpeed >= 1 && mouseSpeed < 2)
        {
            speed_text.text = "1";
        }
        else if(mouseSpeed >= 2 && mouseSpeed < 3)
        {
            speed_text.text = "2";
        }
        else if (mouseSpeed >= 3 && mouseSpeed < 4)
        {
            speed_text.text = "3";
        }
    }
}
