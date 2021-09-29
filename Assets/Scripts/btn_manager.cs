using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btn_manager : MonoBehaviour
{
	public GameObject PopUp;
	public bool aktif;

	public void LoadScene(string scenename)
	{
		SceneManager.LoadScene(scenename);
	}

	public void OnMouseDown()
	{
		PopUp.SetActive(aktif);
	}
}
