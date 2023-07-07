using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Piano : MonoBehaviour
{
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            audioSource.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            audioSource.Stop();
    }
}
