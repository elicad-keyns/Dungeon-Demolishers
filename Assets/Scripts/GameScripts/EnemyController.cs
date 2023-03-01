using UnityEngine;

public class EnemyController : Entity
{
    public float speed = 3f;
    public int damage = 1;

    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (player == null) return;
        // Move towards the player
        transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Damage from the enemy!");
        } 
        if (other.gameObject.tag == "Bullet")
        {
            Debug.Log("Enemy got shot!");
        }
    }

    public override void doDie()
    {
        Destroy(this.gameObject);
    }
}
