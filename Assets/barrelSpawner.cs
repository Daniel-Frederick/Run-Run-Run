using UnityEngine;

public class barrelSpawner : MonoBehaviour
{
    public LogicManager logicManager;
    public GameObject Barrel;
    private float minLimit;
    private float maxLimit;

    void Start() {
        
    }

    void Update() { // Fix the Spawn rates
        if (logicManager.gameTimer <= 10) { // Check amout of time passed
            if (logicManager.resetTimer >= logicManager.timerInterval +3) { // Inital spawn rate
                spawner();
            }
        } else if (logicManager.gameTimer <= 20) {
            if (logicManager.resetTimer >= logicManager.timerInterval) { // Increase spawn rate
                spawner();
            }
        } else { // Max spawn rate
            if (logicManager.resetTimer >= logicManager.timerInterval/2) {
                spawner();
            }
        }
    }
    private void spawner() { Instantiate(Barrel, transform.position, transform.rotation); }
}
