using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolWeapon : BaseWeapon
{
    public PistolWeapon(float fireRate, int damage) : base(fireRate, damage) { }

    public override void Attack(Entity entity)
    {
        entity.doDamage(damage);
    }
}
