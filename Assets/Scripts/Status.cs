using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Status : MonoBehaviour
{

    stats playerhp;
    npchaelth npchp;
    [SerializeField]
    bool poison;
    float ctimea, ntimea = 15, ctimeb, ntimeb = .3f;
    [SerializeField]
    bool resistant, immune, weak;

    [SerializeField]
    Image img;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (this.gameObject.tag == "Player")
        {
            stats stat;
            if (poison)
            {
                img.color = new Color32(0, 255, 0, 100);
                ctimeb += Time.deltaTime;
                stat = this.GetComponent<stats>();

                if (ctimeb >= ntimeb)
                {
                    stat.Setcurrenthaelth(stat.Getcurrenthealth() - 1);
                    ctimeb = 0;
                }

                ctimea += Time.deltaTime;

                if (ctimea >= ntimea)
                {
                    poison = false;
                    ctimea = 0;
                }


            }
            else
            {
                img.color = new Color32(255, 0, 0, 100);
            }
        }
        if (this.gameObject.tag == "Enemy")
        {
            if (poison)
            {
                npchaelth npc;

                ctimeb += Time.deltaTime;
                npc = this.GetComponent<npchaelth>();

                if (ctimeb >= ntimeb)
                {
                    if (immune)
                    {
                        
                    }
                    else if (resistant)
                    {
                        ntimeb = .6f;
                        npc.Setcurrenthaelth(npc.Getcurrenthealth() - 1);
                    }
                    else if (weak)
                    {
                        ntimeb = .15f;
                        npc.Setcurrenthaelth(npc.Getcurrenthealth() - 1);
                    }
                    else
                    {
                        ntimeb = .3f;
                        npc.Setcurrenthaelth(npc.Getcurrenthealth() - 1);

                    }

                    ctimeb = 0;
                }

                ctimea += Time.deltaTime;

                if (ctimea >= ntimea)
                {
                    poison = false;
                    ctimea = 0;
                }
            }
        }
    }
}
