using Live2D.Cubism.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimetionController : MonoBehaviour
{
    public Animator animModel;
    public Animator animCumOutside;
    public Player player;

    private float currentAlert;
    private float currentHorny;
    private float currentHornyPlayer;

    private bool isPlayAlert;
    private bool isPlayHorny;
    private bool isSpreadLegs;
    private bool isFuck;


    void Start()
    {
        animModel = GameObject.Find("Model").GetComponent<Animator>();
        animCumOutside = GameObject.Find("CumOutside").GetComponent<Animator>();      
    }


    void Update()
    {
        currentAlert = SexSystem.currentAlert;
        currentHorny = SexSystem.currentHorny;
        currentHornyPlayer = SexSystem.currentHornyPlayer;
        isFuck = RadiusManeger.isFuck;
        isSpreadLegs = RadiusManeger.isSpreadLegs;

        if (currentAlert == 10f && !isPlayAlert)
        {
            animModel.SetTrigger("isAwake");
            isPlayAlert = true;
        }
        if (currentHorny == 10f && !isPlayHorny && !isSpreadLegs)
        {
            animModel.SetTrigger("isGirlCum1");
            isPlayHorny = true;
            
        }else if (currentHorny == 10f && !isPlayHorny && isSpreadLegs)
        {
            animModel.SetTrigger("isGirlCum2");
            isPlayHorny = true;
        }
        if (currentHornyPlayer == 10f && isFuck)
        {
            animCumOutside.SetBool("isCumInside", true);
        }
        else if (currentHornyPlayer == 10f && !isFuck)
        {
            animCumOutside.SetBool("isCumOutside", true);
        }

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
    }
}
