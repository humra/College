using UnityEngine;
using UnityEngine.AI;

public class Runner : MonoBehaviour
{
    private NavMeshAgent agent;
    private Animator animator;
    private Rigidbody rb;

    public Transform target;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();

        agent.SetDestination(target.position);
    }

    private void Update()
    {
        animator.SetFloat("Speed", agent.velocity.sqrMagnitude);
    }
}
