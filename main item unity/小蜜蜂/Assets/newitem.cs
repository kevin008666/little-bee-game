using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newitem : MonoBehaviour
{
    public GameObject[] items;
    public int[] may;
    int a;
    // Use this for initialization
    void Start()
    {
        a = items.Length;
        InvokeRepeating("u",5,5);
    }

    // Update is called once per frame
    void u()
    {
        int x = Random.Range(0, 100);
        for (int i = 0; i < a; i++)
        {
            if (x < may[i])
            {
                Vector3 v3 = new Vector3(0, 0, 0);
                v3.x = Random.Range(-20f, 20f);
                v3.y = Random.Range(-20f, 20f);
                var c=Instantiate(items[i], v3, transform.rotation);
                Destroy(c, 50);
                return;
            }
        }
        
         
    }
}
