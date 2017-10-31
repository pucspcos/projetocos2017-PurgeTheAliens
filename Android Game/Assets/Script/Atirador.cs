using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atirador : MonoBehaviour
{
    public GameObject bala;
    bool esperar;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetButton("Fire1") && !esperar)
        {
            esperar = true;
            Instantiate(bala, transform.position, Quaternion.identity);
            StartCoroutine(Wait());
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.3f);
        esperar = false;
    }
}
