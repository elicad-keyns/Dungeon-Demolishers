using UnityEngine;

public class Weapon : Entity
{
    public float fireRate = 0.5f;
    public int damage = 1;

    public GameObject bulletPrefab;

    void Start()
    {
        InvokeRepeating("Fire", fireRate, fireRate);
    }

    public void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        bullet.tag = "Bullet";
        Debug.Log("Shot!");
    }
}
