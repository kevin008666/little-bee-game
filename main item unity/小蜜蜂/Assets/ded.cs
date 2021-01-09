using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ded : MonoBehaviour
{
    Text t1;
    // Use this for initialization
    void Start()
    {
        t1 = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        t1.text = "死亡次数:" +player.ded ;
    }
}
