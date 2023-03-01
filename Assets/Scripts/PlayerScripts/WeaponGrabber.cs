using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponGrabber : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Weapon"))
        {
            collision.gameObject.transform.parent = this.gameObject.transform;
            collision.gameObject.transform.localPosition = Vector3.zero;
            CircleCollider2D weaponCollider = collision.gameObject.GetComponent<CircleCollider2D>();
            weaponCollider.radius = 2;
        }
    }
}
