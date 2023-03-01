using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseWeapon : MonoBehaviour
{
    public float fireRate { get; }
    public int damage { get; }

    protected BaseWeapon(float fireRate, int damage)
    {
        this.fireRate = fireRate;
        this.damage = damage;
    }

    public abstract void Attack(Entity entity);

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }
}

//public interface IWeapon
//{
//    void Attack(Entity entity);
//}
