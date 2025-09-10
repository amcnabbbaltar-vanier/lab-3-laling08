using UnityEngine;

public class GunComponent : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public float bulletMaxImpulse = 10.0f;
    public float maxChargeTime = 3.0f;
    private float chargeTime = 0.0f;
    private bool isCharging = false;

    void Update()
    {
        // TO DO: Add the logic to track player by keeping the input down.
        if (Input.GetButtonUp("Fire1"))
        {
            ShootBullet();
        }
    }

    // This method is responsible for creating a bullet object and applying physical force to it so it shoots forward from the gun.
    void ShootBullet()
{
    // Cretaes a new buller in the game by using the bulletPrefa and placing it at the bulletSpawnPoint's position and rotation.
    GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
    
    // Get the RigidBody Component from the bullet.
    Rigidbody rb = bullet.GetComponent<Rigidbody>();
    

    float bulletImpulse = bulletMaxImpulse;

    // Apply force to the bullet in a forward direction of the gun.
    rb.AddForce(bulletSpawnPoint.forward * bulletImpulse, ForceMode.Impulse);
}

   
}
