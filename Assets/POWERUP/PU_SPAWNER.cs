using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PU_SPAWNER : MonoBehaviour
{
    [SerializeField] private GameObject[] PUPrefabs;
    public float PUSpawnTime = 10f;
    public float PUSpeed = 1f;
    //mettiamo che i power up vengono spawnati ogni 10 secondi di default
    private float timeUntilPUSpawn;
    private void Update()
    {
        SpawnLoop();

    }
    private void SpawnLoop()
    {
        timeUntilPUSpawn += Time.deltaTime;
        if (timeUntilPUSpawn >= PUSpawnTime)
        {
            Spawn();
            timeUntilPUSpawn = 0f;
        }
    }

    private void Spawn()
    {
        GameObject PUToSpawn = PUPrefabs[Random.Range(0, PUPrefabs.Length)];

        GameObject spawnedPU = Instantiate(PUToSpawn, transform.position, Quaternion.identity);

        Rigidbody2D PURB = spawnedPU.GetComponent<Rigidbody2D>();
        PURB.velocity = Vector2.left * PUSpeed;
    }
}