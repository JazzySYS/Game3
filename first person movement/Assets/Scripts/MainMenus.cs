using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenus : MonoBehaviour
{
	public static bool optionsOpen = false;

	public void Options()
    {
		optionsOpen = true;
    }

	public void PlayGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		PauseMenu.GameIsPaused = false;
		Time.timeScale = 1f;
	}

	public void QuitGame()
	{
		Debug.Log("quit");
		Application.Quit();
	}
}
