using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AlertSystem : MonoBehaviour
{
    public TextMeshProUGUI textAlert;
    public Slider sliderAlert;
    public Slider sliderHorny;

    private string uiName;
    private float alertMultiplier;
    private float hornyMultiplier;
    private float currentMouseSpeed;
    private int day;

    void Update()
    {
        currentMouseSpeed = MouseSpeed.currentMouseSpeed;
        uiName = MouseClickOn.uiName;
        day = DayManeger.day;

        //Debug ค่าของ sliderAlert.value
        textAlert.text = "Alert : " + sliderAlert.value.ToString();

        gamePlay(uiName);

        //เช็คว่าคลิ้กที่ UIไหม
        if (uiName != null && Input.GetMouseButton(0))
        {
            sliderAlert.value += (currentMouseSpeed * alertMultiplier) * Time.deltaTime;        
        }
        else
        {
            sliderAlert.value -= 0.1f * Time.deltaTime;
            if (sliderAlert.value <= 0f)
            {
                sliderAlert.value = 0f;
            }
        }
        if (uiName != null && uiName != "Shirt_UI" && uiName != "Shorts_UI" && uiName != "Panties_UI" && uiName != "Legs_UI" && uiName != "JerkOff_UI" && Input.GetMouseButton(0))
        {
            sliderHorny.value += (currentMouseSpeed * hornyMultiplier) * Time.deltaTime;
        }

        //Set Alert.value ให้เท่ากับ 0
        if (Input.GetKeyDown(KeyCode.E))
        {
            sliderAlert.value = 0f;
            sliderHorny.value = 0f;
        }
    }

    private void gamePlay(string uiName)
    {
        uiName = this.uiName;

        if (uiName == "Shirt_UI")
        {
            if (day == 1)
            {
                alertMultiplier = 5;
            }
            else if (day == 2)
            {
                alertMultiplier = 3;
            }
            else if (day >= 3)
            {
                alertMultiplier = 0.5f;
            }
        }
        else if (uiName == "Shorts_UI")
        {
            if (day == 1)
            {
                alertMultiplier = 100;
            }
            else if (day == 2)
            {
                alertMultiplier = 2;
            }
            else if (day == 3)
            {
                alertMultiplier = 1;
            }
            else if (day >= 4)
            {
                alertMultiplier = 0.5f;
            }
        }
        else if (uiName == "BoobL_UI" || uiName == "BoobR_UI")
        {
            if (day == 1)
            {
                alertMultiplier = 3;
                hornyMultiplier = 1f;
            }
            else if (day == 2)
            {
                alertMultiplier = 1;
            }
            else if (day >= 3)
            {
                alertMultiplier = 0.5f;
            }
            else
            {
                hornyMultiplier = 0.1f;
            }
        }
        else if (uiName == "Panties_UI")
        {
            if (day == 2)
            {
                alertMultiplier = 5;
            }
            else if (day == 3)
            {
                alertMultiplier = 1;
            }
            else if (day >= 4)
            {
                alertMultiplier = 0.5f;
            }
        }
        else if (uiName == "Legs_UI")
        {
            if (day == 2)
            {
                alertMultiplier = 30;
            }
            else if (day == 3)
            {
                alertMultiplier = 5;
            }
            else if (day == 4)
            {
                alertMultiplier = 3;
            }
            else if (day >= 5)
            {
                alertMultiplier = 0.5f;
            }
        }
        else if (uiName == "Teasing_UI")
        {
            if (day == 2)
            {
                alertMultiplier = 50;
            }
            else if (day == 3)
            {
                alertMultiplier = 1;
            }
            else if (day >= 4)
            {
                alertMultiplier = 0.5f;
            }

            hornyMultiplier = 0.5f;
        }
        else if (uiName == "JerkOffHer_UI")
        {
            if (day == 2)
            {
                alertMultiplier = 50;
            }
            else if (day == 3)
            {
                alertMultiplier = 5;
            }
            else if (day == 4)
            {
                alertMultiplier = 1;
            }
            else if (day >= 5)
            {
                alertMultiplier = 0.5f;
            }

            hornyMultiplier = 0.3f;
        }
        else if (uiName == "JerkOff_UI")
        {
            alertMultiplier = 0.01f;
        }
        else if (uiName == "Insert_UI")
        {
            if (day == 4)
            {
                alertMultiplier = 50;
            }
            else if (day == 5)
            {
                alertMultiplier = 50;
            }
            else if (day == 6)
            {
                alertMultiplier = 0.5f;
            }

            hornyMultiplier = 0.8f;
        }
        else if (uiName == "Fuck_UI")
        {
            if (day == 4)
            {
                alertMultiplier = 50;
            }
            else if (day == 5)
            {
                alertMultiplier = 50;
            }
            else if (day == 6)
            {
                alertMultiplier = 0.5f;
            }

            hornyMultiplier = 1f;
        }
        else
        {
            alertMultiplier = 0.5f;
            hornyMultiplier = 0.5f;
        }
    }
}
