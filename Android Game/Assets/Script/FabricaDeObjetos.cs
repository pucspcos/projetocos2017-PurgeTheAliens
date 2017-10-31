using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FabricaDeObjetos : MonoBehaviour
{
    public GameObject CasaD, PredioD, EscolaD, RuaD, Rua1D, Rua2D,
        CasaE, PredioE, EscolaE, RuaE, Rua1E, Rua2E,
        Rua, Rua1, Rua2, RuaT, RuaT1, RuaT2, RuaT3;

    int sorteioRua, sorteioD, sorteioE;


    void Start()
    {
        InvokeRepeating("CriaRua", 1.24f, 1.26f);
        InvokeRepeating("CriaCenario", 1.24f, 1.26f);
    }

    void Update()
    {

    }

    void CriaRua()
    {
        sorteioRua = Random.Range(1, 20);

        switch(sorteioRua)
        {
            case 1:
                Instantiate(Rua);
                break;
            case 2:
                Instantiate(Rua1);
                break;
            case 3:
                Instantiate(Rua2);
                break;
            case 4:
                Instantiate(RuaT);
                break;
            case 5:
                Instantiate(RuaT1);
                break;
            case 6:
                Instantiate(RuaT2);
                break;
            case 7:
                Instantiate(RuaT3);
                break;
            case 8:
                Instantiate(Rua);
                break;
            case 9:
                Instantiate(Rua1);
                break;
            case 10:
                Instantiate(Rua2);
                break;
            case 11:
                Instantiate(Rua1);
                break;
            case 12:
                Instantiate(Rua2);
                break;
            case 13:
                Instantiate(Rua1);
                break;
            case 14:
                Instantiate(Rua2);
                break;
            case 15:
                Instantiate(Rua1);
                break;
            case 16:
                Instantiate(Rua2);
                break;
            case 17:
                Instantiate(Rua1);
                break;
            case 18:
                Instantiate(Rua2);
                break;
            case 19:
                Instantiate(Rua1);
                break;
            case 20:
                Instantiate(Rua2);
                break;
        }
    }

    void CriaCenario()
    {
        sorteioE = Random.Range(1, 10);
        sorteioD = Random.Range(1, 10);

        if(sorteioRua == 4 || sorteioRua == 6)
        {
            sorteioD = Random.Range(11, 14);
        }
        if (sorteioRua == 5 || sorteioRua == 7)
        {
            sorteioE = Random.Range(11, 14);
        }

        switch (sorteioE)
        {
            case 1:
                Instantiate(CasaE);
                break;
            case 2:
                Instantiate(PredioE);
                break;
            case 3:
                Instantiate(EscolaE);
                break;
            case 4:
                Instantiate(EscolaE);
                break;
            case 5:
                Instantiate(CasaE);
                break;
            case 6:
                Instantiate(CasaE);
                break;
            case 7:
                Instantiate(CasaE);
                break;
            case 8:
                Instantiate(CasaE);
                break;
            case 9:
                Instantiate(PredioE);
                break;
            case 10:
                Instantiate(PredioE);
                break;
            case 11:
                Instantiate(RuaE);
                break;
            case 12:
                Instantiate(Rua1E);
                break;
            case 13:
                Instantiate(Rua2E);
                break;
        }

        switch (sorteioD)
        {
            case 1:
                Instantiate(CasaD);
                break;
            case 2:
                Instantiate(PredioD);
                break;
            case 3:
                Instantiate(EscolaD);
                break;
            case 4:
                Instantiate(EscolaD);
                break;
            case 5:
                Instantiate(CasaD);
                break;
            case 6:
                Instantiate(CasaD);
                break;
            case 7:
                Instantiate(CasaD);
                break;
            case 8:
                Instantiate(CasaD);
                break;
            case 9:
                Instantiate(PredioD);
                break;
            case 10:
                Instantiate(PredioD);
                break;
            case 11:
                Instantiate(RuaD);
                break;
            case 12:
                Instantiate(Rua1D);
                break;
            case 13:
                Instantiate(Rua2D);
                break;
        }
    }
}
