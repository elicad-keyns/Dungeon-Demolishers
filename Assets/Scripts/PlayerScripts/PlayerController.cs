using UnityEngine;

public class PlayerController : Entity
{
    private Rigidbody2D rb;

    public float speed = 5f;
    public float weaponRange = 1f;
    public BaseWeapon weapon;

    private Vector3 rotation = new Vector3(1, 1, 1);

    private Transform enemy;
    // private float timeSinceLastShot = 0f;

    void Start()
    {
        //weapon = new PistolWeapon(Random.Range(1, 5), Random.Range(5, 20));
        rb = GetComponent<Rigidbody2D>();
        enemy = GameObject.FindGameObjectWithTag("Enemy").transform;
    }

    private void Update()
    {
        // Handle player movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Ну тут типа поворчиваем перса, в зависимости от стороны в которую двигается
        if (horizontalInput > 0)
        {
            rotation.x = 1;
            transform.localScale = rotation;
        }
        else if (horizontalInput < 0)
        {
            rotation.x = -1;
            transform.localScale = rotation;
        }

        Vector2 movement = new Vector2(horizontalInput, verticalInput).normalized * speed * Time.fixedDeltaTime;
        //rb.MovePosition(rb.position + movement);
        transform.position += new Vector3(horizontalInput, verticalInput) * speed * Time.deltaTime;

        // Handle weapon behavior
        //if (Vector3.Distance(transform.position, enemy.position) <= weaponRange)
        //{
        //    if (timeSinceLastShot >= weapon.GetComponent<Weapon>().fireRate)
        //    {
        //        weapon.GetComponent<Weapon>().Fire();
        //        timeSinceLastShot = 0f;
        //    }
        //}
        //timeSinceLastShot += Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Debug.Log("Враг йобаный");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Debug.Log("Потеряли...");
        }
    }

    private void FixedUpdate()
    {
        
    }

    public override void doDie()
    {
        Destroy(this.gameObject);
    }
}
