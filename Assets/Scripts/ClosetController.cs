using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ClosetController : MonoBehaviour
{
    public float doorOpenAngle = 90f;
    private bool isOpen = false;
    private float interactionDistance = 1.35f;
    public Transform l_closet;
    public Transform r_closet;
    public TMP_Text textContent;

    private void Update()
    {
        textContent.GameObject().SetActive(false);
        
        if (Vector3.Distance(transform.position, Camera.main.transform.position) <= interactionDistance)
        {
            textContent.GameObject().SetActive(true);
            textContent.text = "Press 'E' to open the closet";
        }
        
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
