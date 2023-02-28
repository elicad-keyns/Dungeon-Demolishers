using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Entity
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private Weapon weapon;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        weapon = GetComponent<Weapon>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (horizontal > 0) {
            transform.localScale = new Vector3(1, 1, 1);
        } else if (horizontal == 0) {

        } else {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        Vector2 movement = new Vector2(horizontal, vertical).normalized * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + movement);

        if (health < 1) {
            Destroy(this);
        }
    }

    void FixedUpdate()
    {

    }

    void onTriggerEnter(Collider other) {
        if (other.CompareTag("Enemy")) {
            weapon.Shoot(other.GetComponent<Transform>());
        }
    }

}
