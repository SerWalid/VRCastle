using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsAct : MonoBehaviour
{
    public AudioClip startSound;

    void Start()
    {
        AudioSource audioSource = GetComponent<AudioSource>();

        if (audioSource == null)
        {
            Debug.LogError("AudioSource component not found on this GameObject!");
            return;
        }

        audioSource.clip = startSound;
        audioSource.Play();
    }
}


