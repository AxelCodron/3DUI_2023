using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTest : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        Debug.Log("ENTER");
    }
    private void OnTriggerStay(Collider other) {
        Debug.Log("STAY");
    }
    private void OnTriggerExit(Collider other) {
        Debug.Log("EXIT");
    }
}
