using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeWeapon : BaseWeapon
{
    [SerializeField]
    public float fireRate = 2f;
    [SerializeField]
    public int damage = 5;
    public RangeWeapon(float fireRate, int damage) : base(fireRate, damage) { }

    public override float FireRate {
        get => fireRate; 
        set => fireRate = value; 
    }
    public override int Damage { 
        get => damage; 
        set => damage = value; 
    }

    private void Start()
    {
        this.enabled = false;
    }

    public override void Attack(Entity entity)
    {
        entity.doDamage(damage);
    }
}
