using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heroi : MonoBehaviour

{
    CharacterController controlador;
    public LevelManager levelManager;
    float Velocidade = 80f;
    Vector3 movimento;
    public int life = 3;
    public int level = 2;
    public GameObject[] lifeImage;
    public GameObject[] fireImage;
    public GameObject[] atiradores;
    public GameObject hit, levelUpSound, lifeUpSound, dieSound;
    public Canvas canvas;


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
        Limites();
        MudaVida();
        VerificaBala();
    }

    private void Limites()
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
            Destroy(other.gameObject);
            if (life > 0)
            {
                life--;
                print(life);
                level = 1;
                GameObject temp = Instantiate(hit, transform.position, Quaternion.identity);
                Destroy(temp, 1);
            }
            else
            {
                canvas.enabled = false;

                GameObject temp = Instantiate(dieSound, transform.position, Quaternion.identity);
                Destroy(temp, 4);
                levelManager.LoadLevel("Menu");
            }
        }

        if (other.gameObject.CompareTag("LifeUp"))
        {
            Destroy(other.gameObject);
            if (life < 3)
            {
                life++;
                GameObject temp = Instantiate(lifeUpSound, transform.position, Quaternion.identity);
                Destroy(temp, 1);
            }
        }

        if (other.gameObject.CompareTag("LevelUp"))
        {
            Destroy(other.gameObject);
            if (level < 3)
            {
                level++;
                GameObject temp = Instantiate(levelUpSound, transform.position, Quaternion.identity);
                Destroy(temp, 1);
            }
        }
    }

    void MudaVida()
    {
        if (life == 0)
        {
            lifeImage[0].SetActive(false);
            lifeImage[1].SetActive(false);
            lifeImage[2].SetActive(false);
        }
        else if (life == 1)
        {
            lifeImage[0].SetActive(true);
            lifeImage[1].SetActive(false);
            lifeImage[2].SetActive(false);
        }
        else if (life == 2)
        {
            lifeImage[0].SetActive(true);
            lifeImage[1].SetActive(true);
            lifeImage[2].SetActive(false);
        }
        else if (life == 3)
        {
            lifeImage[0].SetActive(true);
            lifeImage[1].SetActive(true);
            lifeImage[2].SetActive(true);
        }
    }

    void VerificaBala()
    {
        if (level == 1)
        {
            atiradores[0].SetActive(true);
            atiradores[1].SetActive(false);
            atiradores[2].SetActive(false);
            fireImage[0].SetActive(true);
            fireImage[1].SetActive(false);
        }
        if (level == 2)
        {
            atiradores[0].SetActive(false);
            atiradores[1].SetActive(true);
            atiradores[2].SetActive(true);
            fireImage[0].SetActive(false);
            fireImage[1].SetActive(true);
        }
    }
}
