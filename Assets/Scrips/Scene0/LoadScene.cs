using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;

    private int day;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        day = DayManeger.day;
    }

    private void Update()
    {

    }

    void OnMouseEnter()
    {
        spriteRenderer.enabled = true;
    }

    private void OnMouseDown()
    {
        if (gameObject.name == "Door")
        {
            SceneManager.LoadScene("Scene1");
        }
    }

    void OnMouseExit()
    {
        spriteRenderer.enabled = false;
    }

}
