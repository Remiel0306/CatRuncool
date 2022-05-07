using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2D : MonoBehaviour
{    
    [SerializeField] LayerMask whatIsGround; 
    [SerializeField] float groundCheckRadius = 0.3f;    
    [SerializeField] float jumpForce = 8;
    [SerializeField] float maxSpeed = 3;

    
    Animator animator;
    Rigidbody2D rigidbody;
    Transform groundCheck;    
    // Start is called before the first frame update
    void Start()
    {        
        animator = GetComponent<Animator>();        
        rigidbody = GetComponent<Rigidbody2D>();
        groundCheck = transform.Find("GroundCheck");        
    }
    
    public void Move(float speed, bool jump) {
        if (speed > 0) transform.localScale = new Vector3(1, 1, 1);
        else if (speed < 0) transform.localScale = new Vector3(-1, 1, 1);

        bool onGround;
        if (Physics2D.OverlapCircleAll(groundCheck.position, groundCheckRadius, whatIsGround).Length > 0)
            onGround = true;        
        else
            onGround = false;        
        animator.SetBool("OnGround", onGround);

        if (onGround) {
            if (jump) {
                rigidbody.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
            }
            else {
                Vector3 velocity = transform.right * maxSpeed * speed;
                velocity.y = rigidbody.velocity.y;
                rigidbody.velocity = velocity;

                animator.SetFloat("xSpeed", Mathf.Abs(speed));
            }
        }
        
        animator.SetFloat("ySpeed", rigidbody.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("111" + collision.collider.gameObject.name);
    }
}