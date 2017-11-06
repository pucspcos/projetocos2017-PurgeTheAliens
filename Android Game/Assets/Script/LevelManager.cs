using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public Animator blackMaskAnim;
    public SpriteRenderer black;
    public bool m_AutoLoad = true;
    public string m_LevelToLoad;
    // Use this for initialization
    void Start()
    {
        if (m_AutoLoad)
        {
            Invoke("LoadLevel", 6);
            m_AutoLoad = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadLevel()
    {
        //DadosPersistentes.NextLevel = m_LevelToLoad;
        //SceneManager.LoadScene("Menu");
        StartCoroutine(Fading("Menu"));
    }

    public void LoadLevel(string s_LevelToLoad)
    {
        StartCoroutine(Fading(s_LevelToLoad));
    }

    public void Quit()
    {
        Application.Quit();
    }

    IEnumerator Fading(string s_LevelToLoad)
    {
        blackMaskAnim.SetBool("Fade", true);
        yield return new WaitUntil(() => black.color.a == 1);
        //DadosPersistentes.NextLevel = s_LevelToLoad;
        SceneManager.LoadScene(s_LevelToLoad);
    }
}
