using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseleft : MonoBehaviour
{
    public float ap=10;
    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 4 * Time.deltaTime, 0);
    }
    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.tag=="Finish")
        {
            c.GetComponent<diren>().AddDamage(ap);
            Destroy(gameObject);
        }
    }
}
