using UnityEngine;

/*
    * Basic health script
    * Code by Az Foxxo (https://github.com/AzFoxxo/Scripts)
    * Anarchist License, MIT Licence, GNU GPL v3.0 Licence, or any later version.
*/

public class FPS_Health : MonoBehaviour
{
    [SerializeField] private float InitialHealth;
    [HideInInspector] public float health ;

    // Set the health on awake
    private void Awake() {
        health = InitialHealth;
    }

    // If the actor is at zero health, kill them
    void Update()
    {
        if (health < 1)
            Kill();
    }

    internal virtual void Kill() => Destroy(gameObject);
}
