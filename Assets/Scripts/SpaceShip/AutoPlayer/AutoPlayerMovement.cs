using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoPlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform transform;
    [SerializeField] private Transform keyLeft;
    [SerializeField] private Animator animKeyLeft;
    [SerializeField] private Transform keyRight;
    [SerializeField] private Animator animKeyRight;
    public bool isRight = true;
    public float speed;
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < (keyRight.position.x +1f) && isRight)
        {
            transform.Translate(transform.right * speed * Time.deltaTime);
            animKeyLeft.SetBool("isPressed", false);
            animKeyRight.SetBool("isPressed", true);
            animKeyRight.SetFloat("movement", 1f);
        }
        else
        {
            isRight = false;         
            if(transform.position.x > (keyLeft.position.x -1f) && !isRight)
            {
                transform.Translate((transform.right * speed * Time.deltaTime) * -1);
                animKeyRight.SetBool("isPressed", false);
                animKeyLeft.SetBool("isPressed", true);
                animKeyRight.SetFloat("movement", -1f);
            }
            else
                isRight = true;
        }
    }

    public void leftMovement()
    {

    }

    public void rightMovement()
    {
        
    }
}
