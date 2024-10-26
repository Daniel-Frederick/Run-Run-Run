using UnityEngine;

public class movement : MonoBehaviour
{
    public float moveSpeed = 5;
    void Start() {
        
    }

    void Update() {

        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    }
}
