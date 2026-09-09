using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour
{
    [SerializeField] Transform target;
    private NavMeshAgent agent;
    private float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
      agent = GetComponent<NavMeshAgent>();
      agent.speed = speed;  
      
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = target.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("wall"))
        {
            Vector3 randomPos = 
            transform.position +
            new Vector3(
                Random.Range(-5f,5f),0,Random.Range(-5f,5f)
            );

    agent.SetDestination(randomPos);
        }

        
    }
}
