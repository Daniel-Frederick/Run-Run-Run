using UnityEngine;

public class RockScript : MonoBehaviour
{
    public float moveSpeed = 5;
    private float deleteZone = -13f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < deleteZone)
        {
            Destroy(gameObject);
        }
    }
}
