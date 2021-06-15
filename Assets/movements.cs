using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class movements : MonoBehaviour
{
    [SerializeField] Transform target;
    NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

    }


    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
        
         Vector2 moveDirection = agent.velocity;
         if (moveDirection != Vector2.zero) {
             float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
             transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
         }


    }
}
