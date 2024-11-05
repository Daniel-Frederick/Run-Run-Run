using System;
using UnityEditor.Rendering;
using UnityEngine;
using Random = UnityEngine.Random;

// Spawns Barrels
public class BarrelSpawner : MonoBehaviour
{
    public LogicManager logicManager; // has timer
    public GameObject barrel;
    public float spawnRate = 2f;
    // TODO: Remove the _timer variable and use logicManager's timer instead
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
    }

    private void SpawnBarrel()
    {
        // TODO: Find out if there are variables for the left, top, right, and bottom line of the screen
        float highestY = transform.position.y + heightOffset;
        float lowestY = transform.position.y - heightOffset;
        Instantiate(barrel, new Vector3(transform.position.x, Random.Range(lowestY, highestY), 0), transform.rotation);
    }
}