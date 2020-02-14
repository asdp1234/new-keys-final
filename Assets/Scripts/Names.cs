using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Names : MonoBehaviour
{
    [SerializeField]
    string[] names;

    string currentname;

    int id;

    public string setname()
    {

        id = Random.Range(0, names.Length);

        currentname = names[id];

        return currentname;
    }






}
