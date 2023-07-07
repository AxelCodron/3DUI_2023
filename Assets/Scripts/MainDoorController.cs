using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainDoorController : MonoBehaviour
{
    private float interactionDistance = 1.65f;
    private bool conditionAchieved = false;
    public Transform torch;
    public TMP_Text textContent;

    private void Update()
    {
        textContent.GameObject().SetActive(false);
        conditionAchieved = torch.gameObject.activeSelf;

        if (Vector3.Distance(transform.position, Camera.main.transform.position) <= interactionDistance &&
            conditionAchieved)
        {
            textContent.GameObject().SetActive(true);
            textContent.text = "You can't leave for now, you need to find the torch first";
        }
        
        if (Vector3.Distance(transform.position, Camera.main.transform.position) <= interactionDistance && !conditionAchieved)
        {
            textContent.GameObject().SetActive(true);
            textContent.text = "Press 'E' to open the door";
        }

        if (Vector3.Distance(transform.position, Camera.main.transform.position) <= interactionDistance)
        {
            if (Input.GetKeyDown(KeyCode.E) && !conditionAchieved)
            {
                SceneManager.LoadScene(3);
            }
        }
    }
}
