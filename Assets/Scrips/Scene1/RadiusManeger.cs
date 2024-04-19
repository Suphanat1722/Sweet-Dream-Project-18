using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Live2D.Cubism.Core;
using UnityEngine.XR;

public class RadiusManeger : MonoBehaviour
{
    public CubismModel model;
    public GameObject singletObj;
    public GameObject singleUI;
    public List<GameObject> boobsObj;
    public List<GameObject> boobsUI;
    public GameObject shortsObj;
    public GameObject shortsUI;
    public GameObject teasingObj;
    public GameObject teasingUI;
    public GameObject pantiesObj;
    public GameObject pantiesUI;
    public GameObject legObj;
    public GameObject legUI;
    public GameObject jeckOffHerObj;
    public GameObject jeckOffHerUI;
    public GameObject insertObj; // Index 17
    public GameObject insertUI;
    public GameObject fuckObj;
    public GameObject fuckUI;
    public GameObject jerkOffObj;
    public GameObject jerkOffUI;
    public GameObject handButton;
    public GameObject playerButton;
    public GameObject jeckOffButton;
    public GameObject fuckButton;

    public Player player;

    private bool isTakeOffShirt;
    private bool isTakeOffShorts;
    private bool isTakeOffPanties;
    private bool isClickSwitchHand;
    private bool isInsert;

    public static float currentPlayerOpacity = 0f;
    public static bool isSpreadLegs;
    public static bool isFuck;


    private void Update()
    {
        CheckParametor();
        ButtonChack();

        //ถ้ากดปุ่ม Player
        if (player.isClickPlayer && !AnimetionController.isCumInside)
        {
            currentPlayerOpacity += 0.7f * Time.deltaTime;
            Debug.Log(currentPlayerOpacity);
        }
        if (AnimetionController.isCumInside)
        {
            currentPlayerOpacity -= 0.7f * Time.deltaTime;
        }

        if (currentPlayerOpacity >= 1f && !AnimetionController.isCumInside)
        {
            currentPlayerOpacity = 1f;
        } 
        else if (currentPlayerOpacity <= 0f)
        {
            currentPlayerOpacity = 0f;
        }
    }

    void LateUpdate()
    {
        ChangeValueParametor();
        model.Parts[3].Opacity = currentPlayerOpacity;

    }

    private void CheckParametor()
    {
        //เช็คว่าถอดเสื้อหรือยัง
        if (model.Parameters[1].Value == 10f)
        {
            isTakeOffShirt = true;
        }

        //เช็คว่าถอดกางเกงหรือยัง
        if (model.Parameters[2].Value == 10f)
        {
            isTakeOffShorts = true;
        }

        //เช็คว่าถอดกางเกงในหรือยัง
        if (model.Parameters[3].Value == 10f)
        {
            isTakeOffPanties = true;
        }
        else if (player.isClickPlayer)
        {
            isTakeOffPanties = false;
        }

        //เช็คว่าถางขาหรือยัง
        if (model.Parameters[5].Value == 10f )
        {
            isSpreadLegs = true;
        }
        else if (player.isClickPlayer)
        {
            isSpreadLegs = false;
        }

        //เช็ดว่าเริ่มสอดหรือยัง
        if (model.Parameters[17].Value == 10f)
        {
            isInsert = true;
        }
    }

    private void ChangeValueParametor()
    {
        //ถ้าถอดเสื้อแล้ว
        if (isTakeOffShirt)
        {
            model.Parameters[1].Value = 10f;

            singletObj.SetActive(false);
            singleUI.SetActive(false);

            foreach (GameObject obj in boobsObj)
            {
                obj.SetActive(true);
            }
            foreach (GameObject obj in boobsUI)
            {
                obj.SetActive(true);
            }
        }
        else
        {
            foreach (GameObject obj in boobsObj)
            {
                obj.SetActive(false);
            }
            foreach (GameObject obj in boobsUI)
            {
                obj.SetActive(false);
            }
        }
        //ถ้าถอดกางเกงแล้ว
        if (isTakeOffShorts)
        {
            model.Parameters[2].Value = 10f;

            pantiesObj.SetActive(true);
            pantiesUI.SetActive(true);

            shortsObj.SetActive(false);
            shortsUI.SetActive(false);
        }
        else
        {
            pantiesObj.SetActive(false);
            pantiesUI.SetActive(false);
        }

        //ถ้าถอดกางเกงในแล้ว
        if (isTakeOffPanties)
        {
            model.Parameters[3].Value = 10f;
  
            pantiesObj.SetActive(false);
            pantiesUI.SetActive(false);

            legObj.SetActive(true);
            legUI.SetActive(true);

            if (!player.isClickPlayer)
            {
                teasingObj.SetActive(true);
                teasingUI.SetActive(true);
            }


        }
        else
        {
            legObj.SetActive(false);
            legUI.SetActive(false);

            teasingObj.SetActive(false);
            teasingUI.SetActive(false);

            jeckOffHerObj.SetActive(false);
            jeckOffHerUI.SetActive(false);


        }

        //ถ้าถ่างขาแล้ว
        if (isSpreadLegs)
        {
            model.Parameters[5].Value = 10f;

            if (!isClickSwitchHand && !player.isClickPlayer)
            {
                teasingObj.SetActive(true);
                teasingUI.SetActive(true);

                jeckOffHerObj.SetActive(false);
                jeckOffHerUI.SetActive(false);              
            }
            else if(isClickSwitchHand && !player.isClickPlayer)
            {
                jeckOffHerObj.SetActive(true);
                jeckOffHerUI.SetActive(true);

                teasingObj.SetActive(false);
                teasingUI.SetActive(false);
            }
            else
            {
                jeckOffHerObj.SetActive(false);
                jeckOffHerUI.SetActive(false);

                teasingObj.SetActive(false);
                teasingUI.SetActive(false);
            }

            handButton.SetActive(true);
            playerButton.SetActive(true);

            legObj.SetActive(false);
            legUI.SetActive(false);
        }
        else
        {
            handButton.SetActive(false);
            playerButton.SetActive(false);
        }


        //ถ้ากดปุ่ม Jerk Off
        if (player.isClickJerkOff)
        {
            model.Parameters[23].Value = 10f;
        }
        else
        {
            model.Parameters[23].Value = 0f;
        }

        //ถ้าเริ่มสอดแล้ว
        if (isInsert)
        {
            model.Parameters[17].Value = 10f;

            fuckObj.SetActive(true);
            fuckUI.SetActive(true);

            insertObj.SetActive(false);
            insertUI.SetActive(false);
        }
        else
        {
            fuckObj.SetActive(false);
            fuckUI.SetActive(false);
        }
    }

    private void ButtonChack()
    {
        //เมื่อกดปุ่ม Player
        if (player.isClickPlayer)
        {
           
            jeckOffButton.SetActive(true);
            fuckButton.SetActive(true);
        }
        else
        {
            jeckOffButton.SetActive(false);
            fuckButton.SetActive(false);
        }

        //เมื่อกคลิ้กปุ่ม Jerk Off
        if (player.isClickJerkOff)
        {        
            jerkOffObj.SetActive(true);
            jerkOffUI.SetActive(true);
        }
        else
        {
            jerkOffObj.SetActive(false);
            jerkOffUI.SetActive(false);
        }

        //เมื่อคลิ้กปุ่ม Fuck
        if (player.isClickFuck)
        {
            isFuck = true;

            insertObj.SetActive(true);
            insertUI.SetActive(true);

            jerkOffObj.SetActive(false);
            jerkOffUI.SetActive(false);
        }
        else
        {
            insertObj.SetActive(false);
            insertUI.SetActive(false);
        }
    }

    public void JerkOffHer()
    {
        isClickSwitchHand = !isClickSwitchHand;
    }
}