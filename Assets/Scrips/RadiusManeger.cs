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
    public GameObject handButton;
    public GameObject playerButton;

    private bool isTakeOffShirt;
    private bool isTakeOffShorts;
    private bool isTakeOffPanties;
    private bool isSpreadLegs;
    private bool clickSwitchHand;

    private void Update()
    {
        CheckParametor();
    }

    void LateUpdate()
    {
        ChangeValueParametor();
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

        //เช็คว่าถางขาหรือยัง
        if (model.Parameters[5].Value == 10f)
        {
            isSpreadLegs = true;
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

            teasingObj.SetActive(true);
            teasingUI.SetActive(true);
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

            if (!clickSwitchHand)
            {
                teasingObj.SetActive(true);
                teasingUI.SetActive(true);

                jeckOffHerObj.SetActive(false);
                jeckOffHerUI.SetActive(false);              
            }
            else
            {
                jeckOffHerObj.SetActive(true);
                jeckOffHerUI.SetActive(true);

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
    }

    public void JerkOffHer()
    {
        clickSwitchHand = !clickSwitchHand;
    }
}