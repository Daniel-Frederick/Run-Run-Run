using UnityEngine;

// Behavior for Barrel obstacle
public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private float deleteZone = -13f;

    void Start() { }

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < deleteZone)
        {
            Destroy(gameObject);
        }
    }
}