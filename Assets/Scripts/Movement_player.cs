using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_player : MonoBehaviour
{

    [SerializeField]
    float speed = 5f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector3 move;

 
    // Update is called once per frame
    void Update()
    {
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");
        move.z = 0;

        animator.SetFloat("Horizontal", move.x);
        animator.SetFloat("Vertical", move.y);
        animator.SetFloat("Speed", move.sqrMagnitude);

        move = new Vector3(move.x, move.y,0);
    }

    private void FixedUpdate()
    {
        transform.position = transform.position + move * Time.unscaledDeltaTime; 
    }

}
