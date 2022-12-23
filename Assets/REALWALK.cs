using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class REALWALK : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;

    private Vector2 moveDirection;

    // Update is called once per frame
    void Update()
    {
       // processing inputs 
       ProcessInputs();
    }

     void FixedUpdate()
    {
        // physics calculations
        Move();
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection= new Vector2(moveX, moveY); // come back to this
    }

     void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
}
