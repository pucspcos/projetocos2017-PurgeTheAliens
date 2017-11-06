using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeController : MonoBehaviour
{
    public Animator blackMaskAnim;
    public SpriteRenderer black;
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator Fading()
    {
        blackMaskAnim.SetBool("Fade", true);
        yield return new WaitUntil(() => black.color.a == 1);
    }
}
