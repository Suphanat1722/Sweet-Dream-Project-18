using Live2D.Cubism.Core;
using Live2D.Cubism.Framework;
using Live2D.Cubism.Framework.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class MousePositionPercentageCalculator : MonoBehaviour
{
    public CubismModel model;
    public Clickable clickable;

    public enum EnumParameter
    {
        Nonting,
        Singlet,//1
        Short,//2
        Panties,//3
        Legs,//5
        Teasing,//6,7
        BoobL,//8,9
        BoobR,//10,11
        Fuck,//13
        JerkOff,//15
        JerkOffHer,//16
        Insert//17
    }
    //������͡��ҵ�ͧ��äǺ��� Parameter ����˹
    [SerializeField]
    private EnumParameter selectedParameter;

    public enum EnumDirection
    {
        TopToBottom,
        BottomToTop,
        LeftToRight,
        RightToLeft,
        EveryDirection
    }
    //���ҧ���������ҵ�ͧ�����ҧ������ҡ�ش�˹仨ش�˹
    [SerializeField]
    private EnumDirection selectedDirection;

    private Vector3 posPoin;
    private float maxNumberX, minNumberX;
    private float maxNumberY, minNumberY;
    private float percenYmodel; 
    private float percenXmodel;


    private void Start()
    {   
        posPoin = gameObject.transform.position; //�Ѻ���˹觢ͧ�ش pos �ͧ gameObj
        CalculateMouseRadius();
    }

    private void Update()
    {
        MousePosition();
        
    }

    private void LateUpdate()
    {
        SelectParameter();
    }

    private void SelectParameter()
    {
        if (model != null)
        {
            switch (selectedParameter)
            {
                case EnumParameter.Singlet:
                    model.Parameters[1].Value = percenYmodel;                   
                    break;
                case EnumParameter.Short:
                    model.Parameters[2].Value = percenYmodel;
                    break;
                case EnumParameter.Panties:
                    model.Parameters[3].Value = percenYmodel;
                    break;
                case EnumParameter.Legs:
                    model.Parameters[5].Value = percenYmodel;
                    break;
                case EnumParameter.Teasing:
                    model.Parameters[6].Value = percenXmodel;
                    model.Parameters[7].Value = percenYmodel;
                    break;
                case EnumParameter.BoobL:
                    model.Parameters[8].Value = percenXmodel;
                    model.Parameters[9].Value = percenYmodel;
                    break;
                case EnumParameter.BoobR:
                    model.Parameters[10].Value = percenXmodel;
                    model.Parameters[11].Value = percenYmodel;
                    break;
                case EnumParameter.Fuck:
                    model.Parameters[13].Value = percenYmodel;
                    break;
                case EnumParameter.JerkOff:
                    model.Parameters[15].Value = percenYmodel;
                    break;
                case EnumParameter.JerkOffHer:
                    model.Parameters[16].Value = percenYmodel;
                    break;
                case EnumParameter.Insert:
                    model.Parameters[17].Value = percenYmodel;
                    break;
            }
        }
    }

    private void MousePosition() // �ӹǳ���������������˹��˹������
    {
        if (Input.GetMouseButton(0) && clickable.isClick) // ��Ǩ�ͺ����ա�ä�ԡ�������ҧ
        {
            Vector3 mousePosition = Input.mousePosition; // �Ѻ���˹觢ͧ�������˹�Ҩ�
            mousePosition.z = -Camera.main.transform.position.z; // ��˹���� z �繵��˹觢ͧ���ͧ

            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition); // �ŧ���˹觢ͧ�������˹�Ҩ����š 3 �Ե�

            float normalizedY = 0;
            float normalizedX = 0;

            switch (selectedDirection)
            {
                case EnumDirection.BottomToTop:
                    normalizedY = Mathf.InverseLerp(minNumberY, maxNumberY, worldPosition.y);
                    break;
                case EnumDirection.TopToBottom:
                    normalizedY = Mathf.InverseLerp(maxNumberY, minNumberY, worldPosition.y);
                    break;
                case EnumDirection.LeftToRight:
                    normalizedX = Mathf.InverseLerp(minNumberX, maxNumberX, worldPosition.x);
                    break;
                case EnumDirection.RightToLeft:
                    normalizedX = Mathf.InverseLerp(maxNumberX, minNumberX, worldPosition.x);
                    break;
                case EnumDirection.EveryDirection:
                    normalizedX = Mathf.InverseLerp(minNumberX, maxNumberX, worldPosition.x);
                    normalizedY = Mathf.InverseLerp(minNumberY, maxNumberY, worldPosition.y);
                    break;
            }
            percenYmodel = normalizedY * 100f / 10; // �ŧ normalizedY �������繵� (0-100)
            percenXmodel = normalizedX * 100f / 10; // �ŧ normalizedX �������繵� (0-100)
           // Debug.Log(percenXmodel + " X = "+" Y = " + percenYmodel);
        }

        if (Input.GetMouseButtonUp(0))
        {
            percenXmodel = 0;
            percenYmodel = 0;
        }
        /*else if (percenYmodel >= 10f)
        {           
            percenYmodel = 10f;
        }
        else if(percenYmodel < 10f)
        {
            percenYmodel = 0;
        }*/
    }

    private void CalculateMouseRadius()
    {
        maxNumberX = gameObject.transform.localScale.x / 2 + posPoin.x; // �Ң�Ҵ����բͧ gameObj
        minNumberX = posPoin.x - gameObject.transform.localScale.x / 2; // �ҵ��˹觵Դź�ͧ gameObj �᡹ x

        maxNumberY = gameObject.transform.localScale.y / 2 + posPoin.y; // �Ң�Ҵ����բͧ gameObj
        minNumberY = posPoin.y - gameObject.transform.localScale.y / 2; // �ҵ��˹觵Դź�ͧ gameObj �᡹ y
    }
}
