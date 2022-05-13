using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Character2D : MonoBehaviour
{
    [SerializeField] LayerMask whatIsGround;
    [SerializeField] float groundCheckRadius = 0.3f;
    [SerializeField] float jumpForce = 8;
    [SerializeField] float maxSpeed = 3;
    [SerializeField, Header("動畫參數走路")] private string parameterWalk;    //[SerializeField, Header("AnimatorTrigger")] private string animatorBool;

    Animator animator;
    Rigidbody2D rigidbody;
    Transform groundCheck;
    bool bHide;
    //const string Hide = "hide";
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody2D>();
        groundCheck = transform.Find("GroundCheck");
    }

    private void Update()
    {
        Move(maxSpeed, Input.GetKeyDown(KeyCode.Mouse0));
        Hide();
    }

    public void Move(float speed, bool jump)
    {
        if (speed > 0) transform.localScale = new Vector3(1, 1, 1);
        else if (speed < 0) transform.localScale = new Vector3(-1, 1, 1);

        bool onGround;
        if (Physics2D.OverlapCircleAll(groundCheck.position, groundCheckRadius, whatIsGround).Length > 0)
            onGround = true;
        else
            onGround = false;
        animator.SetBool("OnGround", onGround);

        if (onGround)
        {
            if (jump)
            {
                rigidbody.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
            }
            else
            {
                Vector3 velocity = transform.right * maxSpeed * speed;
                velocity.y = rigidbody.velocity.y;
                rigidbody.velocity = velocity;

                animator.SetFloat("xSpeed", Mathf.Abs(speed));
            }
        }

        animator.SetFloat("ySpeed", rigidbody.velocity.y);
    }

    
    public void Hide()
    {
        if (Input.GetMouseButtonDown(1))
        {
            bHide = true;
            print("<color=yellow>1.Click</color>");    
        }
        else if (Input.GetMouseButtonUp(1))
        {
            bHide = false;
            print("<color=red>2.Click</color>");
        }
        animator.SetBool(parameterWalk, bHide);
        //void ChangeAnimationState(string newState)
        //{
        //    if (hide == true)
        //    {
        //        ChangeAnimationState(Hide);
        //    }
        //}
        //private void OnCollision{
        //Enter2D(Collision2D collision)
        //{
        //    Debug.Log("111" + collision.collider.gameObject.name);
        //}

    }
}