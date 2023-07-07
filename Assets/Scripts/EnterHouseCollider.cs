using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterHouseCollider : MonoBehaviour
{
    public GameObject text;
    private void OnTriggerEnter(Collider other)
    {
        text.SetActive(true);
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            SceneManager.LoadScene(2);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        text.SetActive(false);
    }
}
