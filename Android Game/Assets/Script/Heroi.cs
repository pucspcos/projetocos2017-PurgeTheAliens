using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class Heroi : MonoBehaviour

{
    public PostProcessingProfile Efeitos;
    CharacterController controlador;
    float Velocidade = 80f;
    Vector3 movimento;


    private void Start()
    {
        controlador = GetComponent<CharacterController>();
    }

    void FixedUpdate()
    {
        movimento.z = Input.GetAxis("Horizontal") * Velocidade * Time.deltaTime;
        movimento.x = Input.GetAxis("Vertical") * Velocidade * Time.deltaTime * -1;
        controlador.Move(movimento);
    }
    private void Update()
    {
        if (transform.position.z >= 50)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 50);
        }
        if (transform.position.z <= -50)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -50);
        }
        if (transform.position.x >= 590)
        {
            transform.position = new Vector3(590, transform.position.y, transform.position.z);
        }
        if (transform.position.x <= 470)
        {
            transform.position = new Vector3(470, transform.position.y, transform.position.z);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            movimento.y = -0.6f;
            movimento.x = 0.3f;
            Destroy(other.gameObject);
            
        }
    }
}
