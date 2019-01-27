using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressScene : MonoBehaviour
{
	public PresentScene presentScene;
	//public int nextScene;

	//Use this to determine which scene is to be played next
	public void NextScene(int scene)
	{
		GameObject.FindGameObjectWithTag("SceneManagement").GetComponent<PresentScene>().SwapScene(scene);
	}

	public void ExitGame()
	{
		Debug.Log("QUIT");
		Application.Quit();
	}
}
