using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class time : MonoBehaviour
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
        int a = (int)Time.time;
        int min = a / 60;
        int sec = a % 60;
        string secs = "0";
        if (sec < 10)
        {
            t1.text = min.ToString() + ":0" + sec.ToString();
        }
        else
        {
            t1.text = min.ToString() + ":" + sec.ToString();
        }
    }
}
