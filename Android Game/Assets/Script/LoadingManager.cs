﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class LoadingManager : MonoBehaviour
{
    public TextMeshPro percentual;
    float percentualNum=0;
    AsyncOperation aop;
    // Use this for initialization
    void Start()
    {
        
        aop = SceneManager.LoadSceneAsync(DadosPersistentes.NextLevel);
        aop.allowSceneActivation = false;
    }

    // Update is called once per frame
    void Update()
    {
        percentualNum = Mathf.MoveTowards(percentualNum, aop.progress, Time.deltaTime);
        percentual.text = ((percentualNum*100)+10).ToString("00.0")+"%";
        if( percentualNum > 0.89f)
        {
            aop.allowSceneActivation = true;
        }
    }
}
