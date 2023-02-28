using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour, IHelthSystem
{
    protected int health = 100;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void doDamage(int damage) {
        Debug.Log(damage + " урона ептель");
        health -= damage;
    }

    public void doHeal(int heal) {
        health += heal;
    }

    public void doDie() {
        Destroy(this);
    }

}

public interface IHelthSystem {
    void doDamage(int damage);
    void doHeal(int heal);
    void doDie();
}
