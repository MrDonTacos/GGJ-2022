using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoPlayerShoot : MonoBehaviour
{
    [SerializeField] private Transform bulletPosA;
    [SerializeField] private Transform bulletPosB;
    void Start()
    {
        PrepareBullet();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void PrepareBullet(GameObject bullet)
    {
        bullet.Transform.position = Bullet.position;
        bullet.SetActive(true);
    }
}
