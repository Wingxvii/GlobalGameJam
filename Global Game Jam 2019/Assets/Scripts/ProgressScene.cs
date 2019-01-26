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
		presentScene.SwapScene(scene);
	}

	public void ExitGame()
	{
		Debug.Log("QUIT");
		Application.Quit();
	}
}
