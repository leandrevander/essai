using System;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float MovementDirectionX;
    public float MovementDirectionY;
    public float Speed;
    

    public Rigidbody2D rigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovementDirectionX = Input.GetAxis("Horizontal");
        MovementDirectionY = Input.GetAxis("Vertical");
        
    }

    private void FixedUpdate()
    {
        rigidbody.linearVelocity = new Vector2(MovementDirectionX * Speed, MovementDirectionY * Speed);
    }

    
}
