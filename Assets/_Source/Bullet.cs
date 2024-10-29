using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace  Bullets {
public class Bullet : MonoBehaviour
{
    //todo simple movement
    //todi disabble after lifetime
    private Bullet _bulletPool;
    private static Action<Bullet> OnBulletDisabled;
    /*public void Construct(BulletPool _bulletPool)
    {
        _bulletPool = _bulletPool;
    */}
    private void OnDisable()
    {
        _bulletPool.ReturnToPool(this);
        //OnBulletDisabled?.Invoke(this);
    }
}
}
