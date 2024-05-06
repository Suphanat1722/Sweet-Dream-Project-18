using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSoundMoaning : MonoBehaviour
{
    // Array เก็บชื่อไฟล์เสียง
    public AudioClip[] audioMoaning;
    private AudioSource audioSource;

    private bool isMouseDown = false;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isMouseDown = true;
        }
        else
        {
            isMouseDown = false;
        }

        if (isMouseDown)
        {
            // เล่นเสียงเมื่อคลิกเมาส์ค้างไว้
            if (!audioSource.isPlaying)
            {
                PlayRandomSound();
            }
        }
    }

    private void PlayRandomSound()
    {
        // สุ่มดัชนีไฟล์เสียง
        int randomIndex = Random.Range(0, audioMoaning.Length);

        // โหลดไฟล์เสียง
        AudioClip audioClip = audioMoaning[randomIndex];

        // เล่นไฟล์เสียง
        audioSource.clip = audioClip;
        audioSource.Play();
    }
}
