using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stats : MonoBehaviour
{
    [SerializeField]
    int maxhelth, currenthelth;
    public Slider healthbar;
    // Start is called before the first frame update
    void Start()
    {
        healthbar.maxValue = maxhelth;
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.value = currenthelth;

        if (Input.GetKeyDown(KeyCode.J))
        {
            currenthelth--;
        }
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


