using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiritCollider : MonoBehaviour
{
    public Transform target;
    public List<Vector3> positions;
    private int i = 0;
    private void OnTriggerEnter(Collider other)
    {
        target.position = positions[i];
        i++;
    }
}
