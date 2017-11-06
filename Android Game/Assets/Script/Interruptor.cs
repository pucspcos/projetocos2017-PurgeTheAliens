using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interruptor : MonoBehaviour
{
    public Renderer[] Letras;
    public GameObject[] Textos;
    public Material luz, luzVermelha, vidro, vidroAzul;
    public Slider music, volume;
    public GameObject[] Buttons;
    public GameObject selectSound;

    // Use this for initialization
    void Start()
    {
        Textos[0].SetActive(true);
        Textos[1].SetActive(true);
        Textos[2].SetActive(true);
        Textos[3].SetActive(false);
        Textos[4].SetActive(false);
        Textos[5].SetActive(false);
        Buttons[0].SetActive(true);
        Buttons[1].SetActive(true);
        Buttons[2].SetActive(true);
        Buttons[3].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LigaLuz(string name)
    {
        GameObject temp = Instantiate(selectSound, transform.position, Quaternion.identity);
        Destroy(temp, 0.2f);
        if (name == "New Game")
        {
            for (int i = 0; i < 7; i++)
            {
                Letras[i].sharedMaterial = luz;
            }
        }

        if (name == "Options")
        {
            for (int i = 7; i < 14; i++)
            {
                Letras[i].sharedMaterial = luz;
            }
        }

        if (name == "Exit")
        {
            for (int i = 14; i < 18; i++)
            {
                Letras[i].sharedMaterial = luz;
            }
        }

        if (name == "Voltar")
        {
            Letras[20].sharedMaterial = luzVermelha;
        }
    }

    public void ApagaLuz(string name)
    {
        if (name == "New Game")
        {
            for (int i = 0; i < 7; i++)
            {
                Letras[i].sharedMaterial = vidro;
            }
        }

        if (name == "Options")
        {
            for (int i = 7; i < 14; i++)
            {
                Letras[i].sharedMaterial = vidro;
            }
        }

        if (name == "Exit")
        {
            for (int i = 14; i < 18; i++)
            {
                Letras[i].sharedMaterial = vidro;
            }
        }

        if (name == "Voltar")
        {
            Letras[20].sharedMaterial = vidroAzul;
        }
    }

    public void AbrirOpcoes()
    {
        for(int i = 0; i < 6; i++)
        {
            if (i < 3)
            {
                Textos[i].SetActive(false);
                Buttons[i].SetActive(false);
            }
            else
            {
                Textos[i].SetActive(true);
                Buttons[i].SetActive(true);
            }
        }
    }

    public void FecharOpcoes()
    {
        for (int i = 0; i < 6; i++)
        {
            if (i < 3)
            {
                Textos[i].SetActive(true);
                Buttons[i].SetActive(true);
            }
            else
            {
                Textos[i].SetActive(false);
                Buttons[i].SetActive(false);
            }
        }
        Letras[20].sharedMaterial = vidroAzul;
        for(int i = 0; i < Letras.Length-3; i++)
        {
            Letras[i].sharedMaterial = vidro;
        }
    }
}
