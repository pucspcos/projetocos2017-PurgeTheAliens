using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour
{
    public float direction = -100;
    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(direction, 0, 0);
    }

    void Update()
    {
        if (direction < 0)
        {
            if (transform.position.x <= 240)
            {
                Destroy(gameObject);
            }
        }
    }
}
