using UnityEngine;
using CreatorKitCode;

public class SpawnerSample : MonoBehaviour
{
    //声名一个attribute（字段），是一个游戏对象，用来获取生成器生成的gameobject
    public GameObject ObjectToSpawn;

    //初始化药瓶数量
    public int healthNum = 3;
    //药瓶距离坐标原点初始距离
    public int healthRadius = 3;
    //药瓶间初始化角度
    public int angle = 15;

    void Start()
    {
        //获取游戏对象的位置并赋值给3d对象Vector3      
        Vector3 spawnPosition = transform.position;

        for(int i =0; i <healthNum; i++){
            //四元数Quaternion是unity 3d系统中用来处理旋转的类
        //创建一个方向对象，指定一个方向，并旋转指定角度，生成一个向量坐标
        Vector3 direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        //重新计算 spawnPosition 的值，原来的坐标位置 + 一个方向 * 距离
        spawnPosition = transform.position + direction * healthRadius;
        //用 object 的 instantiate（实例化）静态方法实例化的游戏对象
        Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);
        angle +=40;
        }

    }
}

