using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shroom : MonoBehaviour
{
    [SerializeField]
    GameObject go;

    [SerializeField]
    float[] ctime, ntime;

    [SerializeField]
    Vector3 pos;

    [SerializeField]
    int ammo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < ctime.Length; i++)
        {
            ctime[i] += Time.unscaledDeltaTime;
        }

        if (ctime[0] >= ntime[0] && ammo > 0)
        {
            Instantiate(go,gameObject.transform);
            ctime[0] = 0.0f;
        }
        
    }
}
