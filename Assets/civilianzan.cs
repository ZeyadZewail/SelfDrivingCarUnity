using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class civilianzan : MonoBehaviour
{
    public GameObject  x;
    public GameObject startingposition;
    Vector3 a,b,next;
    NavMeshAgent agent;
    bool way;
    public float speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        a = x.transform.position;
        b = startingposition.transform.position;
        next = a;
        agent.updateRotation = false;
        agent.updateUpAxis = false;

    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(next);
        mmove();
      }


    void mmove() {
        if (transform.position.y >= startingposition.transform.position.y ) {
            next = a;
        }
        if (transform.position.y <= x.transform.position.y) {
            next = b;
        }
    }

}
