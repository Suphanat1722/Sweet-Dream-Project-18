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

        //��ҡ����� Player
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
        //����Ҷʹ����������ѧ
        if (model.Parameters[1].Value == 10f)
        {
            isTakeOffShirt = true;
        }

        //����Ҷʹ�ҧࡧ�����ѧ
        if (model.Parameters[2].Value == 10f)
        {
            isTakeOffShorts = true;
        }

        //����Ҷʹ�ҧࡧ������ѧ
        if (model.Parameters[3].Value == 10f)
        {
            isTakeOffPanties = true;
        }
        else if (player.isClickPlayer)
        {
            isTakeOffPanties = false;
        }

        //����Ҷҧ�������ѧ
        if (model.Parameters[5].Value == 10f )
        {
            isSpreadLegs = true;
        }
        else if (player.isClickPlayer)
        {
            isSpreadLegs = false;
        }

        //�����������ʹ�����ѧ
        if (model.Parameters[17].Value == 10f)
        {
            isInsert = true;
        }
    }

    private void ChangeValueParametor()
    {
        //��Ҷʹ���������
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
        //��Ҷʹ�ҧࡧ����
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

        //��Ҷʹ�ҧࡧ�����
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

        //��Ҷ�ҧ������
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


        //��ҡ����� Jerk Off
        if (player.isClickJerkOff)
        {
            model.Parameters[23].Value = 10f;
        }
        else
        {
            model.Parameters[23].Value = 0f;
        }

        //���������ʹ����
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
        //����͡����� Player
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

        //����͡���须��� Jerk Off
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

        //����ͤ��须��� Fuck
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