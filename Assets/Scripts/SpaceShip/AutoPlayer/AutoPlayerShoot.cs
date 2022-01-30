using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoPlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject bulletA;
    [SerializeField] private GameObject bulletB;
    [SerializeField] private Transform bulletAPos;
    [SerializeField] private Transform bulletBPos;
    private bool isLeft;
    void Start()
    {
        if(!isLeft)
        {
            PrepareBullet(bulletA);
        }
        else
        {
            PrepareBullet(bulletB);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    void PrepareBullet(GameObject bullet)
    {
        if(!isLeft)
        {
            bullet.transform.position = bulletAPos.position;
            bullet.SetActive(true);
        }
        else
        {

        }
    }
}
