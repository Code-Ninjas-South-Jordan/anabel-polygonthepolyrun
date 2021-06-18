using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Default Jumping Power")]
    public float jumpPower = 6f;
    [Header("Boolean isGrounded")]
    public bool isGrounded = false;
    float posX = 0.0f;
    Rigidbody2D rb;
    void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
        posX = transform.position.x;
    }
    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpPower * rb.mass * rb.gravityScale * 20.0f);
        }
    }
    void OnCollisionEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<Collision2D>().Tag == "Ground")
        {
            isGrounded = true;
        }
    }
}