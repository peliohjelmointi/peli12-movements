using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class RawMovement : MonoBehaviour
{
    public float moveSpeed;
    float xSpeed, ySpeed;
    Vector2 moveDirection;

    Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        GetInput();
        //Debug.Log(rb.velocity.magnitude);
    }

    void FixedUpdate()
    {
        MoveRigidBody();
    }

    void GetInput()
    {
        xSpeed = Input.GetAxis("Horizontal");
        ySpeed = Input.GetAxis("Vertical");
        moveDirection = new Vector2(xSpeed, ySpeed);
        
        //moveDirection = moveDirection.normalized;
        
        //moveDirection.Normalize();
        
        if (moveDirection.sqrMagnitude > 1) // Only normalize if necessary        
             moveDirection = moveDirection.normalized;

    }

    void MoveRigidBody()
    {
        rb.velocity = moveDirection * moveSpeed;
    }
}
