using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npchaelth : MonoBehaviour
{
    [SerializeField]
    int maxhelth, currenthelth;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Setmaxhaelth(int hp)
    {

        maxhelth = hp;

    }
    public int Getmaxhealth()
    {

        return maxhelth;
    }
    public void Setcurrenthaelth(int hp)
    {

        currenthelth = hp;

    }
    public int Getcurrenthealth()
    {

        return currenthelth;
    }

}
