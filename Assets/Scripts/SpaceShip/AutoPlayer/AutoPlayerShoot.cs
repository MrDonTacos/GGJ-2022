using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoPlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject bulletA;
    [SerializeField] private GameObject bulletB;
    [SerializeField] private Transform bulletAPos;
    [SerializeField] private Transform bulletBPos;
    [SerializeField] private Animator keyX;
    [SerializeField] private Animator keyZ;
    private bool isLeft = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!isLeft && !bulletB.active)
        {
            keyZ.SetBool("isPressed", false);
            keyX.SetBool("isPressed", true);
            PrepareBullet(bulletA, bulletAPos);
        }
        else if(isLeft && !bulletA.active)
        {
            keyX.SetBool("isPressed", false);
            keyZ.SetBool("isPressed", true);
            PrepareBullet(bulletB, bulletBPos);
        }
    }

    void PrepareBullet(GameObject bullet, Transform bulletPosition)
    {
            bullet.transform.position = bulletPosition.position;
            bullet.SetActive(true);
        if(!isLeft)
            isLeft = true;
        else
            isLeft = false;
    }
}
