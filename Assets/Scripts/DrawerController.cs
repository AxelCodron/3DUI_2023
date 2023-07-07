using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class DrawerController : MonoBehaviour
{
    private bool isOpen = false;
    private float interactionDistance = 1.15f;
    private float zIncrement = 0.457f;
    private bool notPickedUp = true;
    public Transform torch;
    public TMP_Text textContent;

    void Update()
    {
        textContent.GameObject().SetActive(false);
        
        if (Vector3.Distance(transform.position, Camera.main.transform.position) <= interactionDistance && isOpen && notPickedUp)
        {
            textContent.GameObject().SetActive(true);
            textContent.text = "Press 'R' to pick up the torch";
        }
        else if (Vector3.Distance(transform.position, Camera.main.transform.position) <= interactionDistance)
        {
            textContent.GameObject().SetActive(true);
            textContent.text = "Press 'E' to open the drawer";
        }
        if (Vector3.Distance(transform.position, Camera.main.transform.position) <= interactionDistance)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (isOpen)
                {
                    transform.position -= new Vector3(zIncrement, 0f, 0f);
                    torch.position -= new Vector3(zIncrement, 0f, 0f);
                }
                else
                {
                    transform.position += new Vector3(zIncrement, 0f, 0f);
                    torch.position += new Vector3(zIncrement, 0f, 0f);
                }

                isOpen = !isOpen;
            }

            if (Input.GetKeyDown(KeyCode.R) && isOpen && notPickedUp)
            {
                notPickedUp = false;
                torch.gameObject.SetActive(false);
            }
        }
    }
}
