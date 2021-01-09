using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
public class HP : MonoBehaviour
{
    RectTransform rct;
    public float hp = 100;
    // Use this for initialization
    void Start()
    {
        rct = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        rct.offsetMax = new Vector2(10 + player.hp / player.maxHp * 80, -4);

        transform.GetChild(0).GetComponent<Text>().text = 
            player.hp.ToString() + "/" + player.maxHp.ToString();
        if (Input.GetKeyDown(KeyCode.K))
        {
            player.hp -= 10;
        }
    }
}
