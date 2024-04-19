using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LondScene : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false;
    }

    void OnMouseEnter()
    {
        spriteRenderer.enabled = true;
    }

    private void OnMouseDown()
    {
        //Debug.Log("Clicked on the sprite!");
        SceneManager.LoadScene("Scene1");
    }

    void OnMouseExit()
    {
        spriteRenderer.enabled = false;
    }
}
