using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class CameraZoomIntro : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform transform;
    public float speed;
    public Transform machineTransform;
    private MachineAnimations machineScript;
    [SerializeField] private VideoPlayer planeVideo;
    [SerializeField] private Transform planeTransform;

    private bool isZoom = true;
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
        if(isZoom)
        {
            var tmp = machineTransform.position;   
            var tmpRotation = machineTransform.eulerAngles;
            if((tmp.z - 0.75)  <= transform.position.z && ((tmpRotation.y <= -85f && tmpRotation.y >= -100) || (tmpRotation.y >= 260 && tmpRotation.y <= 280)))
            {
                speed = 0;
                isZoom = machineScript.isRotating(false);
            }
            else
            {
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
            }
                
        }
        else
        {
            machineScript.isRotating(false);
            if(!planeVideo.isPlaying && planeVideo.isActiveAndEnabled)
            {
                if(transform.position.y <= 0.165)
                    speed += 0.0005f;
                else
                    speed = 0;
                // transform.Translate(Vector3.forward * speed * Time.deltaTime);
                transform.Translate(Vector3.up * speed * Time.deltaTime);
                Camera.main.fieldOfView -= 0.05f;

                if (Camera.main.fieldOfView <= 2)
                {
                    SceneManager.LoadScene("2d-Game-Human");
                }
            }
        }
    }
}
