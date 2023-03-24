using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    private Vector2 momentum;
    private float topSpeed = 40f;
    private float acceleration = .5f;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        AddPlayerMovement();
        rb.velocity = momentum;
    }

    private void AddPlayerMovement()
    {
        momentum.x += acceleration * Input.GetAxisRaw("Horizontal");
        momentum.y += acceleration * Input.GetAxisRaw("Vertical");

        if(momentum.magnitude > topSpeed)
        {
            momentum = momentum.normalized * topSpeed;
        }
    }
}
