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
        
    }
    void Update()
    {
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.D)|| Input.GetKeyDown(KeyCode.RightArrow))
        {
            sr.flipX = true;
        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
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
