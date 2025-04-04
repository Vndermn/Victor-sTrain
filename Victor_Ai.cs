using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Victor_Ai : MonoBehaviour
{
    //Sight Range
    public float lookRadius = 10f;
    Transform playerTarget;
    NavMeshAgent navAgent;
    // Start is called before the first frame update
    void Awake()
    {
        navAgent.updateRotation = false;
        navAgent.updateUpAxis = false;
    }

    void Start()
    {
        playerTarget = PlayerMovement.instance.player.transform;       
        navAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(playerTarget.position, transform.position);
        if (distance <= lookRadius)
        {
            navAgent.SetDestination(playerTarget.position);
            print("Chasing!");
        }

    }

    void OnDrawGizmosSelected ()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
