using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletA : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter to collider");
        if (other.tag == "Keys")
        {
            gameObject.SetActive(false);
        }
        else if (other.tag == "EnemyRed")
        {
            gameObject.SetActive(false);
        }
        else if (other.tag == "Enemy")
        {
            gameObject.SetActive(false);
        }
    }
}
