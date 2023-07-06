using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiritCollider : MonoBehaviour
{
    public Transform target;
    public List<Vector3> positions;
    private int i = 0;
    private int _security;
    private void OnTriggerEnter(Collider other)
    {
        if (_security == 0)
        {
            target.position = new Vector3(positions[i].x, positions[i].y, positions[i].z);
            Debug.Log("Target is" + positions[i].x + " ," + positions[i].y + ", " + positions[i].z);
            i++;
            _security++;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (_security == 1) {
            _security = 0;
        }
    }
}
