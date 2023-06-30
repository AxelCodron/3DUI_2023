using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDoorController : MonoBehaviour
{
    private float interactionDistance = 1.65f;
    private bool conditionAchieved = false;
    public Transform torch;

    private void OnGUI()
    {
        if (Vector3.Distance(transform.position, Camera.main.transform.position) <= interactionDistance && conditionAchieved)
        {
            GUI.Label(new Rect(Screen.width / 2 - 170, Screen.height - 100, 450, 350), "You can't leave for now, you need to find the torch first");
        }
        else if (Vector3.Distance(transform.position, Camera.main.transform.position) <= interactionDistance && !conditionAchieved)
        {
            GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 100, 150, 50), "Press 'E' to open the door");
        }
    }

    private void Update()
    {
        conditionAchieved = torch.gameObject.activeSelf;

        if (Vector3.Distance(transform.position, Camera.main.transform.position) <= interactionDistance)
        {
            if (Input.GetKeyDown(KeyCode.E) && conditionAchieved)
            {
                // load new scene
            }
        }
    }
}
