using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineAnimations : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator animation;
    public AudioSource audioController;
    public AudioClip coinSound;
    private Transform transform;
    void Start()
    {
        animation = GetComponent<Animator>();
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void isRotating(bool isRotating)
    {
        if(!isRotating)
        {
            animation.SetBool("isRotating", isRotating);
            transform.rotation = Quaternion.Euler(0, -90, 0);
            animation.SetBool("isCoin", true);
            insertCoin();
        }
    }
    private void insertCoin()
    {
        audioController.PlayOneShot(coinSound);
    }
}
