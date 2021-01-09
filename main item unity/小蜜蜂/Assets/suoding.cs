using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suoding : MonoBehaviour
{
    public GameObject g1;
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(!g1)
        {
            Destroy(gameObject);
        }
        transform.position = g1.transform.position;
    }
}
