using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PresentScene : MonoBehaviour
{
	public static PresentScene masterScene;
	bool startGame = false;
	public int loadedScene = 0;

	private void Awake()
	{
		//Locks screen resolution
		Screen.SetResolution(1080, 1920, true);

		if (!startGame)
		{
			masterScene = this;
			//Load start screen with UI
			SceneManager.LoadSceneAsync(1, LoadSceneMode.Additive);
			startGame = true;
		}
	}

	//Use this function to swap scenes
	public void SwapScene(int scene)
	{
		UnloadScene(loadedScene);
		LoadScene(scene);
	}

	//Use this to load the scene
	public void LoadScene(int scene)
	{
		loadedScene = scene;
		SceneManager.LoadSceneAsync(scene, LoadSceneMode.Additive);
	}

	//Use this to unload the scene
	public void UnloadScene(int scene)
	{
		SceneManager.UnloadSceneAsync(scene);
	}
}
