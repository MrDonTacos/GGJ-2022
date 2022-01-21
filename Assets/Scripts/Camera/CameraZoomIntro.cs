using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoomIntro : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform transform;
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
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        Debug.Log("Machine x: " + machineTransform.position.x);
        Debug.Log("Camera x: " + transform.position.x);
        if((machineTransform.position.x -1)  <= transform.position.x)
        {
            machineAnimation.SetBool("isRotating", false);
        }
    }
}
