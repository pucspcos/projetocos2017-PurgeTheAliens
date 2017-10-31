using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emissor : MonoBehaviour
{
    public GameObject Alien, AlienRapido, AlienLento;
    GameObject objetoInstanciado;
    public float atraso, delay;
    Vector3 posicao;

    void Start()
    {
        posicao = new Vector3(transform.position.x, transform.position.y - 12, transform.position.z);
        InvokeRepeating("CriaInimigo", atraso, delay);
    }

    void Update()
    {
        
    }

    void CriaInimigo()
    {
        int sorteioInimigo = Random.Range(1, 10);

        switch (sorteioInimigo)
        {
            case 1:
                objetoInstanciado = Instantiate(AlienLento);
                objetoInstanciado.transform.position = transform.position;
                break;
            case 2:
                objetoInstanciado = Instantiate(Alien);
                objetoInstanciado.transform.position = posicao;
                break;
            case 3:
                objetoInstanciado = Instantiate(Alien);
                objetoInstanciado.transform.position = posicao;
                break;
            case 4:
                objetoInstanciado = Instantiate(Alien);
                objetoInstanciado.transform.position = posicao;
                break;
            case 5:
                objetoInstanciado = Instantiate(AlienRapido);
                objetoInstanciado.transform.position = transform.position;
                break;
            case 6:
                objetoInstanciado = Instantiate(AlienRapido);
                objetoInstanciado.transform.position = transform.position;
                break;
            case 7:
                objetoInstanciado = Instantiate(AlienRapido);
                objetoInstanciado.transform.position = transform.position;
                break;
            case 8:
                objetoInstanciado = Instantiate(AlienRapido);
                objetoInstanciado.transform.position = transform.position;
                break;
            case 9:
                objetoInstanciado = Instantiate(AlienRapido);
                objetoInstanciado.transform.position = transform.position;
                break;
        }
    }
}
