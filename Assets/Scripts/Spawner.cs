using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float spawnRate = 5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spawnRate, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        //GameObject Enemy = Instantiate(prefab, gameObject.transform.position, Quaternion.identity);
    }

    public void Spawn()
    {
        GameObject enemy = Instantiate(prefab, gameObject.transform.position, Quaternion.identity);
        enemy.tag = "Enemy";
    }
}
