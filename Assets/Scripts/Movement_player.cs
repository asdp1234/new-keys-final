using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_player : MonoBehaviour
{

    [SerializeField]
    float speed = 5f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 move;

 
    // Update is called once per frame
    void Update()
    {
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", move.x);
        animator.SetFloat("Vertical", move.y);
        animator.SetFloat("Speed", move.sqrMagnitude);


    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + move * speed * Time.fixedDeltaTime);
    }

}
