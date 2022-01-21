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
        if((machineTransform.position.z -2)  <= transform.position.z)
            machineAnimation.SetBool("isRotating", false);
        else
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
