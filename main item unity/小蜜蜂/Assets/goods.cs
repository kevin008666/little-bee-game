using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goods : MonoBehaviour
{
    public float hp = 0;
    public float maxhp = 0;
    public float rate = 0;
    public float moveSp = 0;
    public int ap = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.tag=="Player")
        {
            player.hp += hp;
            player.maxHp += maxhp;
            player.cd *= (1-rate/100);
            player.moveSeed += moveSp;
            player.arroLevel += ap;
            Destroy(gameObject);
        }
    }
}
