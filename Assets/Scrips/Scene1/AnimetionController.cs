using Live2D.Cubism.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimetionController : MonoBehaviour
{
    public Animator animModel;
    public Animator animCumOutside;
    public Animator animCumInside;
    public Animator animLoadScene;
    public Player player;

    private float currentAlert;
    private float currentHorny;
    private float currentHornyPlayer;

    private bool isPlayAlert;
    private bool isPlayHorny;
    private bool isSpreadLegs;
    private bool isFuck;

    public static bool isCumInside;


    void Start()
    {
        animModel = GameObject.Find("Model").GetComponent<Animator>();
        animCumOutside = GameObject.Find("CumOutside").GetComponent<Animator>();      
        animCumInside = GameObject.Find("CumInside").GetComponent<Animator>();
        animLoadScene = GameObject.Find("Main Camera").GetComponent<Animator>();

    }

    void Update()
    {
        SetVariables();

        if (currentAlert == 10f && !isPlayAlert)
        {
            animModel.SetTrigger("isAwake");
            animLoadScene.SetTrigger("isZoom");
            currentAlert = 0f;
            isPlayAlert = true;
        }
        if (currentHorny == 10f && !isPlayHorny && !isSpreadLegs)
        {
            animModel.SetTrigger("isGirlCum1");
            isPlayHorny = true;

        }
        else if (currentHorny == 10f && !isPlayHorny && isSpreadLegs)
        {
            animModel.SetTrigger("isGirlCum2");
            isPlayHorny = true;
        }
        if (currentHornyPlayer == 10f && isFuck)
        {
            animModel.SetTrigger("isFinished");    
        }
        else if (currentHornyPlayer == 10f && !isFuck)
        {
            animCumOutside.SetBool("isCumOutside", true);
        }

        AfterPlayAnim();
    }

    void SetVariables()
    {
        currentAlert = SexSystem.currentAlert;
        currentHorny = SexSystem.currentHorny;
        currentHornyPlayer = SexSystem.currentHornyPlayer;
        isFuck = RadiusManeger.isFuck;
        isSpreadLegs = RadiusManeger.isSpreadLegs;
    }

    void AfterPlayAnim()
    {
        if (animModel.GetCurrentAnimatorStateInfo(0).IsName("GirlCum1_Anim") &&
            animModel.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.9f)
        {
            isPlayHorny = false;
        }
        if (animModel.GetCurrentAnimatorStateInfo(0).IsName("GirlCum2_Anim") &&
           animModel.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.9f)
        {
            isPlayHorny = false;
        }
        if (animModel.GetCurrentAnimatorStateInfo(0).IsName("CumInside_Anim") &&
           animModel.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.9f)
        {
            animCumInside.SetBool("isCumInside", true);
            isCumInside = true;
        }
        if (animModel.GetCurrentAnimatorStateInfo(0).IsName("Awake_Anim") &&
           animModel.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.9f)
        {
            SceneManager.LoadScene("Scene0");
        }
    }
}
