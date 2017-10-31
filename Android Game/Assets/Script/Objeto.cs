using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objeto : MonoBehaviour
{

    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(100.0f, 0, 0);
    }

    void Update()
    {
        if(transform.position.x > 700)
        {
            Destroy(gameObject);
        }
    }
}
