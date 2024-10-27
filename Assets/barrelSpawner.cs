using System;
using UnityEngine;
using Random = UnityEngine.Random;

// Spawns Barrels
public class BarrelSpawner : MonoBehaviour
{
    public LogicManager logicManager;
    public GameObject barrel;
    public float spawnRate = 2f;
    private float _timer = 0f;
    public float heightOffset = 4f;

    void Start() { }

    void Update()
    {
        // Fix the spawn rates
        if (_timer < spawnRate)
        {
            _timer += Time.deltaTime;
        }
        else
        {
            SpawnBarrel();
            _timer = 0f;
        }

        if (logicManager.gameTimer % 2 == 1)
        {
            Debug.Log("logicManager.gameTimer: " + logicManager.gameTimer);
        }
    }

    private void SpawnBarrel()
    {
        float highestY = transform.position.y + heightOffset;
        float lowestY = transform.position.y - heightOffset;
        Instantiate(barrel, new Vector3(transform.position.x, Random.Range(lowestY, highestY), 0), transform.rotation);
    }
}