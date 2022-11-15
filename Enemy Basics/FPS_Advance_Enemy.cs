using UnityEngine;

/*
    * Basic enemy script with gun fire
    * Code by Az Foxxo (https://github.com/AzFoxxo/Scripts)
    * Anarchist License, MIT Licence, GNU GPL v3.0 Licence, or any later version.
*/

public class FPS_Advance_Enemy : FPS_Enemy
{
    [SerializeField] private GameObject bullet, firePoint;

    [SerializeField] ParticleSystem muzzleFlash;

    float time;
    
    void Start() => time = Time.time + 5;

    // Update is called once per frame
    new void Update()
    {
        // Invoke the enemies update
        base.Update();
        
        // Fire the gun every five secs
        if (navMeshAgent.isActiveAndEnabled)
        {
            if (time - Time.time <= 0) {
                FireGun();

                // Add five secs
                time += 5;
            }
        }

    }

    // Fire the gun
    private void FireGun() {
        muzzleFlash.Play();
        var bulletFired = Instantiate(bullet, firePoint.transform.position, firePoint.transform.rotation);
    }
}
