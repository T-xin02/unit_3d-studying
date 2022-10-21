
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
     //最大生命
     public int MaxHealth = 5 ;
     //开始生命
     private int currentHealth;
    //声明刚体对象
    Rigidbody2D rigidbody2D;
    //获取用户输入
    float horizontal;
    float vertical; 
    public float speed =0.1f;
   // 在第一次帧更新之前调用 Start
   private void Start()
   { 
         //开始生命值
        currentHealth = MaxHealth;
        //获取当前组件的刚体组件
        rigidbody2D = GetComponent<Rigidbody2D>();
  
   }
   // 每帧调用一次 Update
   void Update()
   {
       horizontal = Input.GetAxis("Horizontal");
       vertical = Input.GetAxis("Vertical");      
   }
   private void FixedUpdate()
   {
        Vector2 position = transform.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime; 
        rigidbody2D.position = position;
   }
 
   void ChangeHealth(int amount){
     //系统函数clamp为设置取值范围的函数;限制范围为0——MaxHealth
     currentHealth = Mathf.Clamp(currentHealth + amount ,0,MaxHealth);
     Debug.Log("当前生命值：" + currentHealth +"/"+ MaxHealth);
   }










}
 
