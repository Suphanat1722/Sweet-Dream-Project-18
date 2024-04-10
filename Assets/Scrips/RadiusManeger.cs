using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Live2D.Cubism.Core;
using UnityEngine.XR;

public class RadiusManeger : MonoBehaviour
{
    public CubismModel model;
    public GameObject singletObj;
    public GameObject singleImage;
    public List<GameObject> boobsObj;
    public List<GameObject> boobsImage;
    public GameObject shortsObj;
    public GameObject shortsImage;
    public GameObject teasingObj;
    public GameObject teasingImage;
    public GameObject pantiesObj;
    public GameObject pantiesImage;
    public GameObject legObj;
    public GameObject legImage;

    private bool isTakeOffShirt;
    private bool isTakeOffShorts;
    private bool isTakeOffPanties;
    private bool isSpreadLegs;

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
        if (Input.GetKeyDown(KeyCode.E))
        {
            model.Parameters[3].Value = 10f;
        }

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
            singleImage.SetActive(false);

            foreach (GameObject obj in boobsObj)
            {
                obj.SetActive(true);
            }
            foreach (GameObject obj in boobsImage)
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
            foreach (GameObject obj in boobsImage)
            {
                obj.SetActive(false);
            }
        }
        //��Ҷʹ�ҧࡧ����
        if (isTakeOffShorts)
        {
            model.Parameters[2].Value = 10f;

            pantiesObj.SetActive(true);
            pantiesImage.SetActive(true);

            shortsObj.SetActive(false);
            shortsImage.SetActive(false);
        }
        else
        {
            pantiesObj.SetActive(false);
            pantiesImage.SetActive(false);
        }

        //��Ҷʹ�ҧࡧ�����
        if (isTakeOffPanties)
        {
            model.Parameters[3].Value = 10f;

            pantiesObj.SetActive(false);
            pantiesImage.SetActive(false);

            legObj.SetActive(true);
            legImage.SetActive(true);

            teasingObj.SetActive(true);
            teasingImage.SetActive(true);
        }
        else
        {
            legObj.SetActive(false);
            legImage.SetActive(false);

            teasingObj.SetActive(false);
            teasingImage.SetActive(false);
        }

        //��Ҷ�ҧ������
        if (isSpreadLegs)
        {
            model.Parameters[5].Value = 10f;

            legObj.SetActive(false);
            legImage.SetActive(false);
        }
    }
}