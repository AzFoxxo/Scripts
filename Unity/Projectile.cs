using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float projectileDuration = 5; // time in seconds till object is destroyed
    [SerializeField] private float projectileSpeed; // Speed of projectile
    [SerializeField] private float damageAmount; // Damage caused by project

    private Rigidbody rb; // Projectile's rigidbody

    private void Start()
    {
        // Get the rigidbody
        rb = GetComponent<Rigidbody>();

        // Apply a force to the bullet - movement
        rb.AddForce(transform.up * bulletSpeed, ForceMode.Impulse);

        // Destroy the bullet after so many seconds
        Destroy(gameObject, projectileDuration);
    }
}
