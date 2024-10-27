using System;
using UnityEngine;
using Random = UnityEngine.Random;

// Spawns Barrels
public class BarrelSpawner : MonoBehaviour {
    public LogicManager logicManager;
    public GameObject Barrel;
    public float SpawnRate = 2;
    private float _timer = 0;
    public float HeightOffset = 4;

    void Start() { }

    void Update() { // Fix the Spawn rates

        if (_timer < SpawnRate) {
            _timer += Time.deltaTime;
        }
        else {
            SpawnBarrel();
            _timer = 0;
        }

        if (logicManager.gameTimer % 2 == 1) {
            Debug.Log("logicManager.gameTimer: " + logicManager.gameTimer);
        }

    }

    private void SpawnBarrel() {
        float highestY = transform.position.y + HeightOffset;
        float lowestY = transform.position.y - HeightOffset;
        Instantiate(Barrel, new Vector3(transform.position.x, Random.Range(lowestY, highestY), 0) , transform.rotation);
    }
}
