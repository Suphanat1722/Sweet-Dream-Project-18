using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DayManeger : MonoBehaviour
{
    public static int day = 1;
    public TextMeshProUGUI text_Day;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            day += 1;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            day -= 1;
        }

        text_Day.text = "Day : "+ day.ToString();
    }
}
