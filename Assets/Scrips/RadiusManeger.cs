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

    public bool test;

    private void Update()
    {
        
    }

    void LateUpdate()
    {
        if (model.Parameters[1].Value == 10f)
        {
            
            test = true;
            

        }
        else
        {
            /*foreach (GameObject obj in boobsObj)
            {
                obj.SetActive(false);
            }
            foreach (GameObject obj in boobsImage)
            {
                obj.SetActive(false);
            }*/
        }

        if (test)
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



        if (model.Parameters[2].Value == 10f)
        {
            pantiesObj.SetActive(true);
            pantiesImage.SetActive(true);

            shortsObj.SetActive(false);
            shortsImage.SetActive(false);
        }
        else if (model.Parameters[2].Value < 10f)
        {
            pantiesObj.SetActive(false);
            pantiesImage.SetActive(false);
        }

        if (model.Parameters[3].Value == 10f)
        {
            pantiesObj.SetActive(false);
            pantiesImage.SetActive(false);

            legObj.SetActive(true);
            legImage.SetActive(true);

            teasingObj.SetActive(true);
            teasingImage.SetActive(true);
        }
        else if (model.Parameters[3].Value < 10f)
        {
            legObj.SetActive(false);
            legImage.SetActive(false);

            teasingObj.SetActive(false);
            teasingImage.SetActive(false);
        }

        if (model.Parameters[5].Value == 10f)
        {
            legObj.SetActive(false);
            legImage.SetActive(false);
        }
    }
}