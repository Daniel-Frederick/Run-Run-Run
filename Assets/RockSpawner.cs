using UnityEngine;
using Random = UnityEngine.Random;

public class RockSpawner : MonoBehaviour
{
    public LogicManager logicManager;
    public GameObject rock;
    private float heightOffset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()  { }

    // Update is called once per frame
    void Update()
    {
        if (logicManager.gameTimer % 2 == 0)
        {
            SpawnRock();
        }
    }

    private void SpawnRock()
    {
        // TODO: Find out if there are variables for the left, top, right, and bottom line of the screen
        float highestY = transform.position.y + heightOffset;
        float lowestY = transform.position.y - heightOffset;
        Instantiate(rock, new Vector3(transform.position.x, Random.Range(lowestY, highestY), 0), transform.rotation);
    }
}
