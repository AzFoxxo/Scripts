using UnityEngine;

/*
    * Basic enemy script with gun fire
    * Code by Az Foxxo (https://github.com/AzFoxxo/Scripts)
    * Anarchist License, MIT Licence, GNU GPL v3.0 Licence, or any later version.
*/

public class FPS_Advance_Enemy : FPS_Enemy
{
    [SerializeField] private GameObject bullet, firePoint;

    [SerializeField] private ParticleSystem muzzleFlash;
    
    [SerializeField] private float delay;

    float private time;
    
    void Start() => time = Time.time + delay;

    // Update is called once per frame
    new void Update()
    {
        // Invoke the enemy's update
        base.Update();
        
        // Fire a bullet after the delay
        if (navMeshAgent.isActiveAndEnabled)
        {
            if (time - Time.time <= delay) {
                FireGun();

                // Add five secs
                time += delay;
            }
        }

    }

    // Fire the gun
    private void FireGun() {
        muzzleFlash.Play();
        var bulletFired = Instantiate(bullet, firePoint.transform.position, firePoint.transform.rotation);
    }
}
