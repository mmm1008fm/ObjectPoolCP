using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace PlayerSystem
{

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private Transform firePoint;
    private BulletPool _bulletPooI;
    public void Construct(BulletPool bulletPool)
    {_bulletPooI = bulletPool;}

    }    
    public void Shoot()
    {
    if (_bulletPool.TryGetItem(out var bullet))
    bullet.transform.position = firePoint. position;
    // TODO set rotation, etc
    }

}
}