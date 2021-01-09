using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class player : MonoBehaviour 
{
    public static int ded=0;
    public GameObject boor;
    public static float cd = 0.3f;
    public static int arroLevel = 3;
    public float lastfiretime=-10;
    public static float hp = 100;
    public static float maxHp = 100;
    public static float moveSeed = 2;
    GameObject mousepost;
	void Start () 
	{
        hp = 100;
        mousepost = GameObject.Find("mouse");
	}

	void Update () 
	{
        if(hp<=0)
        {
            ded += 1;
            hp=maxHp;
            transform.position=new Vector3(0, 0, 0);
        }
        float x, y;
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        if (x>0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (x<0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        transform.Translate(x * Time.deltaTime * moveSeed, y * Time.deltaTime * moveSeed, 0);
        if(Input.GetMouseButton(0)&& Time.time-lastfiretime>cd)
        {
            lastfiretime = Time.time;
            int lpy = 0;
            int rpy = 0;
            for (int i = 1; i <=arroLevel; i++)
            {
                var a = Instantiate(boor, transform.position, transform.rotation);
                a.transform.LookAt(mousepost.transform);
                a.transform.Rotate(0, 90, 90);
                if (i==1)
                {
                    continue;
                }
                else
                {
                    if(i%2==0)
                    {
                        a.transform.Rotate(0, 0, i / 2 * 7);
                    }
                    else
                    {
                        a.transform.Rotate(0, 0, -i / 2 * 7);
                    }
                }
            }
        }
        loopMap();
	}

    void loopMap()
    {
        if (transform.position.y> 17)
        {
            transform.Translate(0, -1.28f * 26, 0);
        }
        if (transform.position.y < -17)
        {
            transform.Translate(0, 1.28f * 26, 0);
        }
        if (transform.position.x > 24.32f)
        {
            transform.Translate(-1.28f * 38, 0, 0);
        }
        if (transform.position.x < -24.32f)
        {
            transform.Translate(1.28f * 38, 0, 0);
        }
    }

}



/*	
		Unity一些常用命令。


		以x,y,z为变化单位来移动(x左右,y上下,z前后)
		transform.Translate(x,y,z);

		以x,y,z为旋转轴来旋转(旋转时，指定的轴方向不变。)
		transform.Rotate(x,y,z);
		
		面向pos位置（以z轴指向pos方向）
		transform.LookAt(pos);
		
		取到/设置位置信息。
		transform.position;	
		
		取到/设置方向信息。
		transform.rotation;

		取到/设置大小信息。
		transform.localScale;
		
		四个方向。
		up,down,left,right(依次为上,下,左,右)

		取到两点之间的距离。
		Vector3.Distance(a,b);
		
		轴名称：
		"Vertical"		垂直
		"Horizontal"	水平
		

		取到对应按键按压状态信息
		Input.GetKey("w");

		取到鼠标按键按压信息
		Input.GetMouseButton(0);

		取到鼠标位置
		Input.mousePosition;

		

*/

