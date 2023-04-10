using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    private Rigidbody2D rb;

    // ENCAPSULATION
    private Vector2 m_momentum;
    public Vector2 momentum
    {
        get { return m_momentum; }
        set { m_momentum = value.magnitude <= maxSpeed ? value : m_momentum; }
    }
    [SerializeField]
    private float maxAcceleration = 5f;
    [SerializeField]
    private float m_acceleration = .5f;
    public float acceleration
    {
        get { return m_acceleration; }
        set { m_acceleration = value > maxAcceleration ? maxAcceleration : value; }
    }
    [SerializeField]
    private float m_maxSpeed = 40f;
    public float maxSpeed
    {
        get { return m_maxSpeed; }
        set
        {
            if(value >= 0f)
            {
                m_maxSpeed = value;
            }
            else
            {
                print("Can't set max speed to zero or less");
            }
        }
    }



    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        AddPlayerMovement();
        rb.velocity = momentum;
        print(maxSpeed);
    }

    private void AddPlayerMovement()
    {

        momentum += new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * acceleration;

        if (momentum.magnitude > maxSpeed)
        {
            momentum = momentum.normalized * maxSpeed;
        }
    }
}
