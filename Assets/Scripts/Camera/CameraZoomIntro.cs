using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraZoomIntro : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform transform;
    public float speed;
    public Transform machineTransform;
    private MachineAnimations machineScript;
    void Start()
    {
        transform = GetComponent<Transform>();
        machineScript = machineTransform.GetComponent<MachineAnimations>();
        // machineAnimation = machineTransform.GetComponent<Animator>();
    }
    // Update git
    // Update is called once per frame
    void Update()
    {
        var tmp = machineTransform.position;   
        var tmpRotation = machineTransform.eulerAngles;
        if((tmp.z - 0.75)  <= transform.position.z && ((tmpRotation.y <= -85f && tmpRotation.y >= -100) || (tmpRotation.y >= 260 && tmpRotation.y <= 280)))
        {
            speed = 0;
            machineScript.isRotating(false);
        }
        else
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
