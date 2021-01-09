using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diren : MonoBehaviour
{
    public float hp = 1000;
    public float maxhp = 1000;
    public GameObject dd;
    GameObject player;
    
    // Use this for initialization
    void Start()
    {
        //StartCoroutine(klloop());
        StartCoroutine(moveloop());
        player = GameObject.Find("小蜜蜂");
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AddDamage(float dmg)
    {
        hp -= dmg;
        if(hp<=0)
        {
            Destroy(gameObject);
        }
    }

    //IEnumerator klloop()
    //{
        //yield return 0;
        //for (int i = 0; i < 10; i++)
        //{
            //if (Vector3.Distance(transform.position,player.transform.position)>8)
            //{
                //continue;
            //}
            //for (int g = 0; g < 5; g++)
            //{
                //var a=Instantiate(dd, transform.position, transform.rotation);

                //a.transform.LookAt(player.transform, Vector3.right);
                //a.transform.Rotate(0, 90, 90+(g - 2) * 12);
                
            //}
            
            //yield return new WaitForSeconds(0.5f);
        //}
        //yield return new WaitForSeconds(5);

        //StartCoroutine(klloop());
    //}

    public static float SuperRd(float min, float max,float rd)
    {
        int flag = 0;
        if (Random.Range(0,2)==1)
        {
            flag = 1;
        }
        else
        {
            flag = -1;
        }

        return flag*Random.Range((min+max)/2+rd,max) ;
    }



    IEnumerator moveloop()
    {
        yield return 0;

        for (int i = 0; i < 10; i++)
        {
            transform.position = player.transform.position + new Vector3(SuperRd(-3,3,2), SuperRd(-3, 3, 2),0);
            for (int g = 0; g < 3; g++)
            {
                var a = Instantiate(dd, transform.position, transform.rotation);

                a.transform.LookAt(player.transform, Vector3.right);
                a.transform.Rotate(0, 90, 90 + (g - 1) * 15);

            }
            yield return new WaitForSeconds(0.5f);
        }


        yield return new WaitForSeconds(5);
        StartCoroutine(moveloop());
    }


}
