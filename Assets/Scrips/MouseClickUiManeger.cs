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

    private void Update()
    {
        text_UiName.text = "Mouse on : " + MouseClickOn.uiName;
        text_RawSpeed.text = "MouseSpeed :" + MouseSpeed.currentMouseSpeed;
        text_SpeedAvg.text = "Speed Avg: " + MouseSpeed.mouseSpeedAvg;
    }
}
