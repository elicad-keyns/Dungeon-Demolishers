using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseWeapon : MonoBehaviour
{
    public abstract float FireRate { get; set; }
    public abstract int Damage { get; set; }

    protected BaseWeapon(float fireRate, int damage)
    {
        this.FireRate = fireRate;
        this.Damage = damage;
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
