using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerJump : MonoBehaviour
{
    public float jumpSpeed, xOffset, yOffset, xSize, ySize;
    private Rigidbody2D rb;
    public bool isGrounded;
    public LayerMask groundMask;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapBox(new Vector2(transform.position.x + xOffset, transform.position.y + yOffset),new Vector2(xSize,ySize),0f, groundMask);
        if(Input.GetKeyDown(KeyCode.UpArrow)&& isGrounded){
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        }
        playerVariables.isJumping = !isGrounded;
    }
 private void OnDrawGizmosSelected() {
     Gizmos.color = Color.red;
     Gizmos.DrawCube(new Vector2(transform.position.x + xOffset, transform.position.y + yOffset),new Vector2(xSize,ySize));
        
}
}
