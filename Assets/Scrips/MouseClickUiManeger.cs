using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class MouseClickUiManeger : MonoBehaviour
{
    public TextMeshProUGUI text_UiName;
    public TextMeshProUGUI text_RawSpeed;
    public TextMeshProUGUI text_SpeedAvg;

    private  int mouseSpeedAvg;

    private void Update()
    {
        text_UiName.text = "Mouse on : " + MouseClickOn.uiName;
        text_RawSpeed.text = "MouseSpeed :" + MouseSpeed.currentMouseSpeed;

        if (MouseSpeed.currentMouseSpeed <= 1 && MouseSpeed.currentMouseSpeed < 2)
        {
            text_SpeedAvg.text = "Speed Avg: " + mouseSpeedAvg.ToString();
        }
        else if (MouseSpeed.currentMouseSpeed >= 2 && MouseSpeed.currentMouseSpeed < 3)
        {
            text_SpeedAvg.text = "Speed Avg : " + mouseSpeedAvg.ToString();
        }
        else if (MouseSpeed.currentMouseSpeed >= 3 && MouseSpeed.currentMouseSpeed < 4)
        {
            text_SpeedAvg.text = "Speed Avg : " + mouseSpeedAvg.ToString();
        }
    }
}
