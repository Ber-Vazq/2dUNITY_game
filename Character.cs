using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour{
    public float moveSpeed;
    public Rigidbody2D rb;

    private Vector2 moveInput;
    // Update is called once per frame
    void Update()
    {
        //for input
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical"); 
        moveInput.Normalize();

        rb.velocity = (moveInput*moveSpeed);
    }
}