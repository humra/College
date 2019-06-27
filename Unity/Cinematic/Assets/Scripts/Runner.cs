using UnityEngine;
using UnityEngine.AI;

public class Runner : MonoBehaviour
{
    private NavMeshAgent agent;
    private Animator animator;
    private Rigidbody rb;
    private float timestamp;

    public Transform[] target;

    private bool moved = true;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();

        timestamp = Time.time + 3;
    }

    private void Update()
    {
        animator.SetFloat("Speed", agent.velocity.sqrMagnitude);

        if(timestamp <= Time.time && moved)
        {
            agent.SetDestination(target[0].position);
            moved = false;
        }
    }
}
