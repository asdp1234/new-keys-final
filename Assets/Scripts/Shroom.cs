using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shroom : ObjectCompendium
{
    [SerializeField]
    GameObject go;
    GameObject pgo;


    Movement_player player;

    [SerializeField]
    float ctime, ntime;

    [SerializeField]
    Vector3 pos;

    [SerializeField]
    int ammo;


    [SerializeField]
    float distance;
    // Start is called before the first frame update
    void Start()
    {
        pgo = GameObject.FindGameObjectWithTag("Player");
        player = pgo.GetComponent<Movement_player>();

    }

    // Update is called once per frame
    void Update()
    {
      

       distance = Vector3.Distance(player.transform.position, transform.position);

        ctime += Time.unscaledDeltaTime;
       

        if (ctime >= ntime)
        {
            Instantiate(go,gameObject.transform);
            ctime = 0.0f;
        }
        if (distance < .2f)
        {
            player.GetComponent<Status>().Poisonon();
        }
        
    }
}
