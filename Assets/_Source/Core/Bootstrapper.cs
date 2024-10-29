using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace PlayerSystem
{
public class Bootstrapper : MonoBehaviour
{
    [SerializeField] private Bullet bulletPrefab;
    private BulletPool _bulletPool;
    void start ()
    {
        //var bulletPool = new BulletPool();
        _bulletPool = new (bulletPrefab);
    }
}
}
