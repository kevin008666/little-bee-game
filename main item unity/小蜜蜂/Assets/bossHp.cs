using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bossHp : MonoBehaviour
{
    RectTransform rct;
    // Use this for initialization
    void Start()
    {
        rct = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        diren e;
        e = transform.parent.GetComponent<suoding>().g1.GetComponent<diren>();


        rct.offsetMax = new Vector2(10 + e.hp / e.maxhp * 80, -4);

        transform.GetChild(0).GetComponent<Text>().text =
            e.hp.ToString() + "/" + e.maxhp.ToString();
    }
}
