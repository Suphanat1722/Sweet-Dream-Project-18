using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSoundMoaning : MonoBehaviour
{
    // Array �纪���������§
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
            // ������§����ͤ�ԡ������ҧ���
            if (!audioSource.isPlaying)
            {
                PlayRandomSound();
            }
        }
    }

    private void PlayRandomSound()
    {
        // �����Ѫ��������§
        int randomIndex = Random.Range(0, audioMoaning.Length);

        // ��Ŵ������§
        AudioClip audioClip = audioMoaning[randomIndex];

        // ���������§
        audioSource.clip = audioClip;
        audioSource.Play();
    }
}
