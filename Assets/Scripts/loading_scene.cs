using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loading_scene : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Loading());
    }
    public Image loadingfill;
    IEnumerator Loading()
    {
        AsyncOperation loading = SceneManager.LoadSceneAsync("Scene 2");

        while (!loading.isDone)
        {
            loadingfill.fillAmount = loading.progress / 0.9f;
            yield return null;
        }
    }
}
