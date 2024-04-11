using Live2D.Cubism.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CubismModel model;
    public GameObject insertObj; // Index 17
    public GameObject insertUI;
    public GameObject fuckObj;
    public GameObject fuckUI;

    public bool isInsert;
    private bool isClick;

    private void Start()
    {
        model.Parts[3].Opacity = 0f;

        insertObj.SetActive(false);
        insertUI.SetActive(false);
        fuckObj.SetActive(false);
        fuckUI.SetActive(false);
    }
    private void Update()
    {
        //Debug.Log(model.Parameters[17].Value);
        if (model.Parameters[17].Value == 10f && isClick)
        {
            isInsert = true;
        }
    }

    private void LateUpdate()
    {
        Debug.Log(model.Parameters[17].Value);
        if (isClick)
        {
            model.Parts[3].Opacity = 1f;

            insertObj.SetActive(true);
            insertUI.SetActive(true); 
        }

        if (isInsert)
        {
            model.Parameters[17].Value = 10f;

            insertObj.SetActive(false);
            insertUI.SetActive(false);

            fuckObj.SetActive(true);
            fuckUI.SetActive(true);
        }
    }

    public void OpacityParts()
    {
        isClick = true;
    }
}
