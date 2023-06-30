using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosetController : MonoBehaviour
{
    public float doorOpenAngle = 90f;
    private bool isOpen = false;
    private float interactionDistance = 1.35f;
    public Transform l_closet;
    public Transform r_closet;

    private void OnGUI()
    {
        if (Vector3.Distance(transform.position, Camera.main.transform.position) <= interactionDistance)
        {
            GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 100, 170, 70), "Press 'E' to open the closet");
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
                    r_closet.rotation = Quaternion.Euler(0f, r_closet.rotation.eulerAngles.y + 90f, 0f);
                    l_closet.rotation = Quaternion.Euler(0f, l_closet.rotation.eulerAngles.y - 90f, 0f);
                }
                else
                {
                    r_closet.rotation = Quaternion.Euler(0f, r_closet.rotation.eulerAngles.y - 90f, 0f);
                    l_closet.rotation = Quaternion.Euler(0f, l_closet.rotation.eulerAngles.y + 90f, 0f);
                }

                isOpen = !isOpen;
            }
        }
    }
}
