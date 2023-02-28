using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform character;
    public GameObject bulletPrefab;
    public float fireRate = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", fireRate, fireRate);
    }

    public void Shoot(Transform enemy) 
    {
        GameObject bullet = Instantiate(bulletPrefab, character.position, character.rotation);
        Vector3 direction = enemy.transform.position - character.position;
        bullet.transform.LookAt(enemy.transform.position);
    }
}
