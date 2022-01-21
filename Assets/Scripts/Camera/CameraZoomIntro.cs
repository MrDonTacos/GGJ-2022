using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraZoomIntro : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform transform;
    private Transform transformCopy;
    public float speed;
    public Transform machineTransform;
    public Animator machineAnimation;
    void Start()
    {
        transform = GetComponent<Transform>();
        machineAnimation.SetBool("isRotating", true);
    }

    // Update is called once per frame
    void Update()
    {
        var tmp = machineTransform.position;   
        float tmpRotation = machineTransform.rotation.y * 100;
        Debug.Log("Float: " + tmpRotation);
        Debug.Log("Integer: " + (int)tmpRotation);
        if((tmp.z - 0.7)  <= transform.position.z && (int)tmpRotation == -83)
        {
            machineAnimation.SetBool("isRotating", false);
            speed = 0;
            // machineTransform.rotation = Quaterion.Euler(0, -90, 0);
        }
        else
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
