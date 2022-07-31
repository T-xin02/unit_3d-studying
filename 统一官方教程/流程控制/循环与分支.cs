using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{
    /*
    public string myName ="猪八戒";
    public int myHp = 50;
    public int myAp = 3; 
    */
    // Start is called before the first frame update
    public char grade ='B';

void Start()
    {

    switch (grade)
    {
      case 'A':
        Debug.Log("很棒！");
        break;
      case 'B':
      case 'C':
        Debug.Log("做得好");
        break;
      case 'D':
        Debug.Log("您通过了");
        break;
      case 'F':
        Debug.Log("最好再试一下");
        break;
      default:
        Debug.Log("无效的成绩");
        break;
    }
    Debug.Log($"您的成绩是 {grade}");

       /*
       Debug.Log("我的名字是:" + myName);  
       Debug.Log("我的生命值是："+ myHp);
       Debug.Log("我的初始攻击是："+myAp);
       */

       /*
       int monter = 10;
       int i = 1;
       while (i <= monter){
        Debug.Log($"$第{i}马...");
        i++;
       }
       Debug.Log("马数完了..");
     
       int monter = 10;
       int i = 1;

       do
       {
        Debug.Log($"第{i}马...");
        i++;
       }while(i <= monter);

       Debug.Log("马数完了...");
      

       int monter = 10;

       for(int i=1;i <=10;i++)
       {
        Debug.Log($"第{i}马...");
       }

       Debug.Log("马数完了...");
        */

        



    }


}
