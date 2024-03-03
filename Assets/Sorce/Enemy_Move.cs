using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_Move : MonoBehaviour
{
    public string targetObjectName;

    GameObject targetObject;
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        targetObject = GameObject.Find(targetObjectName);
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = targetObject.transform.position;
    }
}
