using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour, IHelthSystem
{
    protected int health = 100;

    public void doDamage(int damage) {
        Debug.Log(damage + " урона ептель");
        health -= damage;
    }

    public void doHeal(int heal) {
        health += heal;
    }

    public abstract void doDie();

}

public interface IHelthSystem {
    void doDamage(int damage);
    void doHeal(int heal);
}
