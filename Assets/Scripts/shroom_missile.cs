using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shroom_missile : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb;

   
   public Movement_player player;


    [SerializeField]
    float speed;

    Vector2 temp;

    // Start is called before the first frame update
    void Start()
    {

        player = player.GetComponent<Movement_player>();

    }

    // Update is called once per frame
    void Update()
    {

        rb.rotation += -165.0f * Time.unscaledDeltaTime;

        temp = Vector2.MoveTowards(transform.position, player.transform.position, (speed * Time.deltaTime));

        transform.position = new Vector3(temp.x, temp.y, -0.5f);




    }
}
