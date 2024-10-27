using UnityEngine;

public class barrelSpawner : MonoBehaviour
{
    public LogicManager logicManager;
    public GameObject Barrel;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 1;

    void Start() {
        
    }

    void Update() { // Fix the Spawn rates
        //if (logicManager.gameTimer <= 10) { // Check amout of time passed
        //    if (logicManager.resetTimer >= logicManager.timerInterval) { // Inital spawn rate
        //        spawnBarrel();
        //    }
        //} else if (logicManager.gameTimer <= 20) {
        //    if (logicManager.resetTimer >= logicManager.timerInterval) { // Increase spawn rate
        //        spawnBarrel();
        //    }
        //} else { // Max spawn rate
        //    if (logicManager.resetTimer >= logicManager.timerInterval) {
        //        spawnBarrel();
        //    }
        //}

        if (timer < spawnRate) {
            timer += Time.deltaTime;
        } else {
            spawnBarrel();
            timer = 0;
        }


    }

    private void spawnBarrel() {
        float highestY = transform.position.y + heightOffset;
        float lowestY = transform.position.y - heightOffset;
        Instantiate(Barrel, new Vector3(transform.position.x, Random.Range(lowestY, highestY), 0) , transform.rotation);
    }
}
