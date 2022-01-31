using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBAuto : MonoBehaviour
{
    public float speed;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter to collider");
        if (other.tag == "Keys")
        {
            // Hazard hazard = other.GetComponent<Hazard>();
            // if (hazard != null)
            // {
            //     hazard.Deactivate();
            // }
            gameObject.SetActive(false);
        }
        // else
        // {
        //     Enemy enemy = other.GetComponent<Enemy>();
        //     if (enemy != null)
        //     {
        //         bulletPoolObject.ReturnToPool();
        //         enemy.HitTimesForStunned--;
        //     }
        // }
        else if (other.tag == "Enemy")
        {
            // Hazard hazard = other.GetComponent<Hazard>();
            // if (hazard != null)
            // {
            //     hazard.Deactivate();
            // }
            gameObject.SetActive(false);
        }
    }
}
