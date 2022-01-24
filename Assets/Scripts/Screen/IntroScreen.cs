using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroScreen : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject transform;
    void Start()
    {
        transform = GetComponent<GameObject>();
        transform.active = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void activateScreen() 
    {
        transform.active = true;
    }
}
