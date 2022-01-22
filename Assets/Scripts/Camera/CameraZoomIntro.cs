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
    }

    // Update is called once per frame
    void Update()
    {
        var tmp = machineTransform.position;   
        var tmpRotation = machineTransform.eulerAngles;
        if((tmp.z - 0.75)  <= transform.position.z && ((tmpRotation.y <= -85f && tmpRotation.y >= -100) || (tmpRotation.y >= 260 && tmpRotation.y <= 280)))
        {
            machineAnimation.SetBool("isRotating", false);
            speed = 0;
            machineTransform.rotation = Quaternion.Euler(0, -90, 0);
        }
        else
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
