using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour {

    public float velocidade;
    public int hp;
    public GameObject hit, hpUp, levelUp;
    int rnd;
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
            rnd = Random.Range(1, 15);
            if(rnd < 5)
            {
                GameObject temp = Instantiate(hpUp, transform.position, Quaternion.identity);
                temp.transform.position = new Vector3(temp.transform.position.x, 60, temp.transform.position.z);
            }
            if (rnd > 10)
            {
                GameObject temp = Instantiate(levelUp, transform.position, Quaternion.identity);
                temp.transform.position = new Vector3(temp.transform.position.x, 60, temp.transform.position.z);
            }
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Tiro"))
        {
            hp--;
            GameObject temp = Instantiate(hit, transform.position, Quaternion.identity);
            Destroy(temp, 1);
            Destroy(other.gameObject);        
        }
    }
}
