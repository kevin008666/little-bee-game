using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newdrin : MonoBehaviour
{
    public GameObject a;
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("u", 60, 30);
    }

    // Update is called once per frame
    void u()
    {
        Vector3 v3 = new Vector3(0, 0, 0);
        v3.x = Random.Range(-20f, 20f);
        v3.y = Random.Range(-20f, 20f);
        var c = Instantiate(a, v3, transform.rotation);
    }
}
