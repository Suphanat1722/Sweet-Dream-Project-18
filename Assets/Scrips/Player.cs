using Live2D.Cubism.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public bool isClickPlayer;
    public bool isClickJerkOff;
    public bool isClickFuck;

    public void OpacityParts()
    {
        isClickPlayer = true;
    }

    public void JerkOffButton()
    {
        isClickJerkOff = true;
        isClickFuck = false;
    }

    public void FuckButton()
    {
        isClickFuck = true;
        isClickJerkOff = false;
    }

}
