using UnityEngine;
using TMPro;
using System;
using Unity.VisualScripting;

public class DoorController : MonoBehaviour
{
    public float doorOpenAngle = 90f;
    private bool isOpen = false;
    private float interactionDistance = 1.65f;
    public TMP_Text textContent;

    private void Update()
    {
        textContent.GameObject().SetActive(false);
        
        if (Vector3.Distance(transform.position, Camera.main.transform.position) <= interactionDistance)
        {
            textContent.GameObject().SetActive(true);
            textContent.text = "Press 'E' to open the door";
        }
        if (Vector3.Distance(transform.position, Camera.main.transform.position) <= interactionDistance)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (isOpen)
                {
                    transform.rotation = Quaternion.Euler(0f, transform.rotation.eulerAngles.y + 90f, 0f);
                }
                else
                {
                    transform.rotation = Quaternion.Euler(0f, transform.rotation.eulerAngles.y - 90f, 0f);
                }

                isOpen = !isOpen;
            }
        }
    }
}