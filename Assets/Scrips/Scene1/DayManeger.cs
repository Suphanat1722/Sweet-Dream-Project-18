using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Live2D.Cubism.Core;
using Unity.VisualScripting;

public class DayManeger : MonoBehaviour
{
    public static int day = 1;
    public TextMeshProUGUI text_Day;
    public CubismModel model;

    private void Start()
    {
        
        model = GameObject.Find("Model").GetComponent<CubismModel>();
    }

    void Update()
    {
        

        if (SexSystem.currentHorny >= 5f)
        {
            
            LoadScene.LoadNewScene("Scene0");
        }

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
