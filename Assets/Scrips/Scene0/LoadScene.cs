using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Animator animLoadScene;
    public static LoadScene instance;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animLoadScene = GameObject.Find("Main Camera").GetComponent<Animator>();
    }

    void OnMouseEnter()
    {
        spriteRenderer.enabled = true;
    }

    void OnMouseDown()
    {
        if (gameObject.name == "Door")
        {
            animLoadScene.SetTrigger("isZoom0");
            StartCoroutine(LoadScene1AfterAnimation());
        }
    }

    IEnumerator LoadScene1AfterAnimation()
    {
        yield return new WaitForSeconds(2f); // Adjust the delay as needed
        SceneManager.LoadScene("Scene1");
    }
    IEnumerator LoadScene0AfterAnimation()
    {
        yield return new WaitForSeconds(2f); // Adjust the delay as needed
        SceneManager.LoadScene("Scene0");
    }

    void OnMouseExit()
    {
        spriteRenderer.enabled = false;
    }

    public static void LoadNewScene(string name)
    {
        if (name == "Scene1")
        {
            //instance.StartCoroutine(instance.LoadScene1AfterAnimation());
        }
        else if (name == "Scene0")
        {
            //instance.StartCoroutine(instance.LoadScene0AfterAnimation());
        }
    }
}
