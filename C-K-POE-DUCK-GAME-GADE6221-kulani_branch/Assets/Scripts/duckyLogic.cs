using System;
using System.Runtime.CompilerServices;
using Unity.Burst;
using UnityEngine;
using UnityEngine.InputSystem;


[RequireComponent(typeof(CharacterController))]
public class duckyLogic : MonoBehaviour
{
    [Header("Game Stats")]
    
    public float moveSpeed = 20f;

    public float jumpForce = 10f;

    public float gameSpeed = 10f;

    public float moveX;

    public float moveZ;

    private Rigidbody rb;
    

    public float speed = 5f;
    public float jumpHeight = 20f;
    public float gravity = -5f; // Stronger gravity feels better in games

    private CharacterController controller;
    private Vector3 velocity;
    private bool isGrounded;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        // 1. Ground Check
        isGrounded = controller.isGrounded;
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f; // Keeps the player stuck to the floor
        }

        // 2. Horizontal Movement (WASD)
        float x = 0;
        float z = 0;


        var kb = Keyboard.current;
        if (kb != null)
        {
           
            if (kb.aKey.isPressed) x = -1;
            if (kb.dKey.isPressed) x = 1;
        }

        // Calculate movement relative to where the player is facing
        // 3. Jumping (Space Bar)
        if (kb.spaceKey.wasPressedThisFrame && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);

        }
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);


        // 4. Apply Gravity
        velocity.y += gravity * Time.deltaTime;

        // 5. Final Vertical Movement
        controller.Move(velocity * Time.deltaTime);

    }

    /*
    private void MoveX()
    {
        float moveX = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(moveX, 0f, 0f);

        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }

    private void MoveZ()
    {
        float moveX = Input.GetAxis("Veritcal");

        Vector3 movement = new Vector3(0f, 0f, moveZ);

        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }

    private void CheckGround()
    {
       // grounded = Physics.CheckSphere(groundCheck.position, groundCheckRadius, groundLayer);
    }

    private void Jump()
    {
        var kb = Keyboard.current;
        // 1. Ground Check
        isGrounded = controller.isGrounded;
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f; // Keeps the player stuck to the floor
        }

       

        // 3. Jumping (Space Bar)
        if (kb != null && kb.spaceKey.wasPressedThisFrame && isGrounded)
        {
            if (kb.spaceKey.isPressed) velocity.y = 4;

        }

        // 4. Apply Gravity
        velocity.y += gravity * Time.deltaTime;

        // 5. Final Vertical Movement
        controller.Move(velocity * Time.deltaTime);



       
         
          
        
        moveX = Keyboard.current.rightArrowKey.isPressed ? 1f : Keyboard.current.leftArrowKey.isPressed ? -1f : 0f;

        rb.linearVelocity = new Vector2(moveX * moveSpeed, rb.linearVelocity.y);

        if (Keyboard.current.spaceKey.wasPressedThisFrame && grounded)
        {
            rb.linearVelocity = new Vector2(0f, jumpForce);

        }
        */

}
/*
private void OnCollisionEnter(Collision collision)
{
    if (collision.gameObject.CompareTag("Ground"))
    {
        Vector3 normal = collision.GetContact(0).normal;
        if (normal == Vector3.up)
        {
            isGrounded = true;
        }
    }
}

private void OnCollisionExit(Collision collision)
{
    if (collision.gameObject.CompareTag("Ground"))
    {
        isGrounded = false;

    }
}
*/

