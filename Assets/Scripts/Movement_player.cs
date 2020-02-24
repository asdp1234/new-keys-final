using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_player : MonoBehaviour
{
    [SerializeField]
    SpriteRenderer sr;

    [SerializeField]
    float speed = 5f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 move;


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
        if (move.x == 0 && move.y == 0)
        {
            sr.flipX = true;
        }
        else
        {
            sr.flipX = false;
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
