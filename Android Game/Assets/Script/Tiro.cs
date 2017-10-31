using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour
{

    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(-100,0,0);
    }

    void Update()
    {
        if(transform.position.x <= 240)
        {
            Destroy(gameObject);
        }
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Enemy"))
    //    {
    //        Destroy(gameObject);
    //    }
    //}
}
