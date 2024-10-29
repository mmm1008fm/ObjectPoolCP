using System.Collections;
using System.Collections.Generic;
using System.Data;
using Bullets;
using UnityEngine;
namespace PlayerSystem
{

public class BulletPool : MonoBehaviour
{
    private Queue<Bullet> _bulletPool;
    private const int _startPoolSize = 10;
    public BulletPool(Bullet bulletPrefab)
    {
        InitPool(bulletPrefab);
    }
    public BulletPool(Bullet[] bullets)
    {
        InitPool(bullets);
    }

    private void InitPool(Bullet bulletPrefab)  
    {
        _bulletPool = new();
        for (int i = 0; i < _startPoolSize; i++)
        {
            Bullet bulletInstance = Object.Instantiate(bulletPrefab);
            _bulletPool.Enqueue(bulletInstance);
            bulletInstance.Construct(this);
        }
        //Bullet.OnBulletDisabled += ReturnToPool;
    }


    //private void InitPool(Bullet[] bullets)  
    //{
    //    //fill queue with args
    //}

    public bool TryGetItem(out Bullet bullet)
    {
        /*bullet = null;
        if (_bulletPool.Count> 0)
        {
            bullet = _bulletPool.Dequeue();
            return true;
        }
        return false;
        */
        //bersion 2
        return _bulletPool.TryDequeue(out bullet);
    }
    public void ReturnToPool(Bullet bullet)
    {
        _bulletPool.Enqueue(bullet);
    }
}
}