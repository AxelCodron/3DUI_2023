using UnityEngine;
using TMPro;
using System;

public class DoorController : MonoBehaviour
{
    public float doorOpenAngle = 90f;
    private bool isOpen = false;
    private float interactionDistance = 1.65f;

    private void OnGUI()
    {
        if (Vector3.Distance(transform.position, Camera.main.transform.position) <= interactionDistance)
        {
            GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 100, 150, 50), "Press 'E' to open the door");
        }
    }

    private void Update()
    {
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