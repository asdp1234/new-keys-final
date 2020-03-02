using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_player : MonoBehaviour
{
    [SerializeField]
    SpriteRenderer sr;

    [SerializeField]
    Sprite up, down, left, right;


    [SerializeField]
    float speed = 5f;

    public Rigidbody2D rb;
    public Animator animator;


    private bool isMoveRight;
    private bool isMoveLeft;
    private bool isMoveUp;
    private bool isMoveDown;
    private bool isidle;



    Vector2 move;
    float idelX, idelY;


    // Update is called once per frame
    private void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
        sr.flipX = true;
    }
    void Update()
    {
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", move.x);
        animator.SetFloat("Vertical", move.y);
        animator.SetFloat("Speed", move.sqrMagnitude);
        animator.SetFloat("IdelX", idelX);
        animator.SetFloat("IdelY", idelY);

        if (move.x > 0 && move.y == 0)
        {
            idelX = 1.0f;
        }
        if (move.x < 0 && move.y == 0)
        {
            idelX = -1.0f;
        }
        if (move.y > 0 && move.x == 0)
        {
            idelY = 1.0f;
        }
        if (move.y < 0 && move.x == 0 )
        {
            idelY = -1.0f;

        }


        



        if (move.x > 0)
        {
            move.x = 1;
        }
        if (move.y > 0)
        {
            move.y = 1;
        }
        if (move.x < 0)
        {
            move.x = -1;
        }
        if (move.y < 0)
        {
            move.y = -1;
        }
      
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + move * speed * Time.fixedDeltaTime);
    }


    public Vector3 getpostion()
    {
        return this.transform.position;
    }
}
