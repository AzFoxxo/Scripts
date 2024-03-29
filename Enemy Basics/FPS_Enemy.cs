using UnityEngine;
using UnityEngine.AI;

/*
    * Basic enemy script for chasing the player
    * Code by Az Foxxo (https://github.com/AzFoxxo/Scripts)
    * Anarchist License, MIT Licence, GNU GPL v3.0 Licence, or any later version.
*/

[RequireComponent(typeof(FPS_Health))]
public class FPS_Enemy : MonoBehaviour
{
    internal NavMeshAgent navMeshAgent;

    [SerializeField] private float damageAmount;
    [SerializeField] private float attackDelay;
    [SerializeField] private float attackRate;
    [SerializeField] private float attackDistance;

    [HideInInspector] public Transform target;

    // Reference to the player
    private void Awake()
    {
        target = GameObject.FindWithTag("Player").transform;
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    public void Update()
    {
        if (Time.time > attackDelay)
        {
            navMeshAgent.destination = target.position;
            if (Vector3.Distance(target.position, transform.position) <= attackDelay)
            {
                target.GetComponent<PlayerHealth>().health -= damageAmount;
                attackDelay = Time.time + attackRate;
            }
        }
        else
        {
            navMeshAgent.destination = transform.position;
        }
    }
}
