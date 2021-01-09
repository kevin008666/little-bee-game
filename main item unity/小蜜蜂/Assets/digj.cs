using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class digj : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 3 * Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.tag=="Player")
        {
            player.hp -= 10;
            Destroy(gameObject);
        }
    }
}
