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

        //����Ҷҧ�������ѧ
        if (model.Parameters[5].Value == 10f)
        {
            isSpreadLegs = true;
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

        //��Ҷ�ҧ������
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