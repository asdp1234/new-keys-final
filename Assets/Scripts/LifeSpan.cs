using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeSpan : MonoBehaviour
{
    [SerializeField]
    Names namechecker;

    public GameObject spawn;
    [SerializeField]
    float min;
    [SerializeField]
    float secconds,neededsecconds;
    [SerializeField]
    int generation;

    public Text gen;
    public Text name;
    public Text agetxt;

    [SerializeField]
    int startage, maxage, age;
    [SerializeField]
    float timeinyear, currentttime;
    // Start is called before the first frame update
    void Start()
    {
        namechecker = namechecker.GetComponent<Names>();



        generation = 1;
        name.text = "Name: " + namechecker.setname().ToString();
        gen.text = "Generation: " + generation.ToString();
        neededsecconds = (min * 60);

        startage = Random.Range(18, 21);
        maxage = Random.Range(80, 88);
        timeinyear = ((neededsecconds / (maxage - startage)));
        age = startage;
        agetxt.text = "Age: " + age.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        secconds += Time.unscaledDeltaTime;
        currentttime += Time.unscaledDeltaTime;

        if (secconds >= neededsecconds)
        {
            respawn();
        }
        if (age >= maxage)
        {
            respawn();
        }

        if (currentttime >= timeinyear)
        {
            currentttime = 0;
            age++;
            agetxt.text = "Age: " + age.ToString();
        }

        if (age > 68)
        {
            //speed 1/3
        }


    }

    void respawn()
    {
        this.transform.SetPositionAndRotation(spawn.transform.position, Quaternion.identity);
        secconds = 0;
        generation++;
        name.text = "Name: " + namechecker.setname().ToString();
        gen.text = "Generation: " + generation.ToString();
        Debug.Log(generation);

        //-------------------------------------------------

        startage = Random.Range(18, 21);
        maxage = Random.Range(80, 88);
        age = startage;
        agetxt.text = "Age: " + age.ToString();
        timeinyear = ((neededsecconds / (maxage - startage)));

    }
}
