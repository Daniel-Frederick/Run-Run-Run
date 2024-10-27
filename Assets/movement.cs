using UnityEngine;

public class movement : MonoBehaviour
{
    public float moveSpeed = 5;
    private float deleteZone = -13;

    void Start() {
        
    }

    void Update() {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < deleteZone) {
            Destroy(gameObject);
        }
    }
}
