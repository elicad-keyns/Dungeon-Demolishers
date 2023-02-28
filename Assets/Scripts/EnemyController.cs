using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : Entity
{
    public float moveSpeed = 5.0f;
    private Rigidbody2D rb;
    private Transform target;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (target == null) return;
        // Определяем направление к цели
        Vector2 direction = target.position - transform.position;

        if (direction.x > 0) {
            transform.localScale = new Vector3(1, 1, 1);
        } else if (direction.x == 0) {

        } else {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        // Поворачиваем врага в сторону цели
        // transform.right = direction;
    }

    void FixedUpdate()
    {
        if (target == null) return;
        // Определяем направление к цели
        Vector2 direction = target.position - transform.position;

        // Нормализуем направление и устанавливаем скорость
        direction.Normalize();
        rb.velocity = direction * moveSpeed;
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            target = other.GetComponent<Transform>();

            // PlayerController player = other.GetComponent<PlayerController>();
            // player.doDamage(10);
        }
    }


}
