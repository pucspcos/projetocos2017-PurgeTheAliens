using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour {

    public float velocidade;
    public int hp;
    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(velocidade, 0, 0);
    }

    void Update()
    {
        if (transform.position.x > 700)
        {
            Destroy(gameObject);
        }

        if(hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Tiro"))
        {
            hp--;
            Destroy(other.gameObject);
        }
    }
}
