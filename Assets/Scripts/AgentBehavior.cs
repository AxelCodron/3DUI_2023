using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentBehavior : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform target;
    public Transform spiritPosition;

    private void Start()
    {
        target.position = spiritPosition.position;
    }

    void Update()
    {
        agent.SetDestination(target.position);
    }
}
