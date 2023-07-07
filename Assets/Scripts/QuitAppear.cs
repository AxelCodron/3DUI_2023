using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitAppear : MonoBehaviour
{
    public GameObject quitButton;
    void Start()
    {
        StartCoroutine(AwaitQuitButton());
    }

    private IEnumerator AwaitQuitButton()
    {
        yield return new WaitForSeconds(4);
        quitButton.SetActive(true);
    }
}
