using UnityEngine;
using CreatorKitCode;

public class SpawnerSample : MonoBehaviour
{
    //声名一个attribute（字段），是一个游戏对象，用来获取生成器生成的gameobject
    public GameObject ObjectToSpawn;
    //声明一个变量，用来存放距离
    public int radius;
    //start事件方法，是包含此脚本的游戏对象 Start is called just before any of the update methods is called the first time
    //在 update 前执行，且在游戏对象生命周期只执行一次
    //start is only called once in the lifetime of the behaviour。
    void Start()
    {
        //声名整型变量 angle 并赋值为 15
        int angle = 15;

        //声名一个3D Vector（矢量）对象。spawnposition并赋值为当前游戏对象的位置
        Vector3 spawnPosition = transform.position;

        //声明一个3D Vector（矢量）对象。direction，并使用 Quaternion（四元数）类的静态方法 Euler（欧拉）返回值 * Vector（1，0，0）
        //四元数 Quaternion 是unity 3d 系统中，用来处理旋转的类
        //说白了就是创建一个方向对象，指定一个方向，旋转多少度，然后生成一个向量坐标
        Vector3 direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        //重新计算 spawnPosition 的值，原来的坐标位置 + 一个方向 * 距离
        spawnPosition = transform.position + direction * radius;
        //用 object 的 instantiate（实例化）静态方法实例化的游戏对象
        Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);

        //用一套数值，在新的位置重新生成一个游戏对象
        angle = 35;
        direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        spawnPosition = transform.position + direction * radius;
        Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);

        //用一套数值，在新的位置重新生成一个游戏对象
        angle = 55;
        direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        spawnPosition = transform.position + direction * radius;
        Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);

        //用一套数值，在新的位置重新生成一个游戏对象
        angle = 75;
        direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        spawnPosition = transform.position + direction * radius;
        Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);

        //用一套数值，在新的位置重新生成一个游戏对象
        angle = 95;
        direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        spawnPosition = transform.position + direction * radius;
        Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);
    }
}
