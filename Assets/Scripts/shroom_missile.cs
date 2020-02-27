using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shroom_missile : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb;

    GameObject go;
   
   
    Movement_player player;
   
    stats playerstats;

    [SerializeField]
    float timedestroy = 3, ctime;


    [SerializeField]
    float speed;

    Vector2 temp;

    // Start is called before the first frame update
    void Start()
    {

        go = GameObject.FindGameObjectWithTag("Player");
        player = go.GetComponent<Movement_player>();
        playerstats = go.GetComponent<stats>();

    }

    // Update is called once per frame
    void Update()
    {

        rb.rotation += -165.0f * Time.unscaledDeltaTime;

        temp = Vector2.MoveTowards(transform.position, player.transform.position, (speed * Time.deltaTime));

        transform.position = new Vector3(temp.x, temp.y, -0.5f);

        ctime += Time.unscaledDeltaTime;

        if (ctime >= timedestroy)
        {
            Destroy(gameObject);
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {

            playerstats.Setcurrenthaelth(playerstats.Getcurrenthealth() - 10);

            Destroy(gameObject);
        }
    }
}
