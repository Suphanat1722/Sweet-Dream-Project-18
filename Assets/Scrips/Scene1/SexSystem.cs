using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class SexSystem : MonoBehaviour
{
    public TextMeshProUGUI textAlert;
    public Slider sliderAlert;
    public Slider sliderHorny;
    public Slider sliderHornyPlayer;

    public static float currentAlert = 0f;
    public static float currentHorny = 0f;
    public static float currentHornyPlayer = 0f;


    private float alertMultiplier;
    private float hornyMultiplier;
    private float hornyPlayerMultiplier;
    private string uiName;
    private float currentMouseSpeed;
    private int day = 1;

    private void Awake()
    {
        currentAlert = 0f;
        currentHorny = 0f;
        currentHornyPlayer = 0f;
    }

    void Update()
    {
        currentMouseSpeed = MouseSpeed.currentMouseSpeed;
        uiName = MouseClickOn.uiName;
        day = DayManeger.day;

        //Debug ค่าของ sliderAlert.value
        textAlert.text = "Alert : " + sliderAlert.value.ToString();

        gamePlay(uiName);

        //เช็คว่าคลิ้กที่ UIไหมและคำนวณค่าใน slide
        if (uiName != null && Input.GetMouseButton(0))
        {
            sliderAlert.value += (currentMouseSpeed * alertMultiplier) * Time.deltaTime;        
        }else if (sliderAlert.value >= 10f)
        {
            sliderAlert.value = 10f;
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

        if (uiName != null && (uiName == "JerkOff_UI" || uiName == "Insert_UI" || uiName == "Fuck_UI") && Input.GetMouseButton(0))
        {
            sliderHornyPlayer.value += (currentMouseSpeed * hornyPlayerMultiplier) * Time.deltaTime;
        }

        //เก็บค่าของ Slider ไว้ในตัวแปร
        currentAlert = sliderAlert.value;
        currentHorny = sliderHorny.value;
        currentHornyPlayer = sliderHornyPlayer.value;

        if (sliderHorny.value >= 10f)
        {
            sliderHorny.value = 0f;
        }
        if (sliderHornyPlayer.value >= 10f)
        {
            sliderHornyPlayer.value = 0f;
        }

        //Set Alert.value ให้เท่ากับ 0
        if (Input.GetKeyDown(KeyCode.E))
        {
            sliderAlert.value = 0f;
            sliderHorny.value = 0f;
            hornyPlayerMultiplier = 0f;
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
            hornyPlayerMultiplier = 0.5f;
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
                hornyPlayerMultiplier = 0.5f;
            }
            else if (day == 6)
            {
                alertMultiplier = 0.5f;
                hornyPlayerMultiplier = 0.5f;
            }

            hornyMultiplier = 1f;
        }
        else
        {
            alertMultiplier = 0.5f;
            hornyMultiplier = 0.5f;
            hornyPlayerMultiplier = 0.5f;
        }
    }
}
