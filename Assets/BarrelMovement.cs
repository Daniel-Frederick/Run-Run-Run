using System;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class BarrelMovement : MonoBehaviour
{
    public LogicManager logicManager;
    public float moveSpeed = 5f;
    private float deleteZone = -13f;

    void Start()
    {
            GameObject logicObject = GameObject.FindGameObjectWithTag("Logic");
            if (logicObject != null)
            {
                logicManager = logicObject.GetComponent<LogicManager>();
            }
            else
            {
                Debug.LogError("LogicManager GameObject with tag 'Logic' not found in the scene.");
            }
    }

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < deleteZone)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("OnCollisionEnter2D went off ");
        logicManager.gameOver();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Trigger overlap detected with " + collider.gameObject.name);
        logicManager.gameOver();
    }
}
