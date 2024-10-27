using UnityEngine;

// Movement for main character
public class MoveScript : MonoBehaviour
{
    public float moveSpeed = 8f;
    private Vector2 movement; // Input value

    void Start() { }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    // FixedUpdate is called at a fixed interval, good for physics-related updates
    void FixedUpdate()
    {
        transform.Translate(movement * moveSpeed * Time.fixedDeltaTime);
    }
}