using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float weaponRange = 1f;
    public GameObject weapon;

    private Transform enemy;
    private float timeSinceLastShot = 0f;

    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy").transform;
    }

    void Update()
    {
        // Handle player movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.position += new Vector3(horizontalInput, verticalInput, 0) * speed * Time.deltaTime;

        // Handle weapon behavior
        if (Vector3.Distance(transform.position, enemy.position) <= weaponRange)
        {
            if (timeSinceLastShot >= weapon.GetComponent<Weapon>().fireRate)
            {
                weapon.GetComponent<Weapon>().Fire();
                timeSinceLastShot = 0f;
            }
        }
        timeSinceLastShot += Time.deltaTime;
    }
}
