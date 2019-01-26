using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
	public AudioSource source;
	public List<AudioClip> soundList;

    // Start is called before the first frame update
    void Start()
    {
		source.GetComponent<AudioSource>();
    }

	// 1- Walk sounds
	int GetRandomSound(int soundType)
	{
		int soundLoc = 0;
		if (soundType == 1)
		{
			soundLoc = Random.Range(0, 3);
		}

		return soundLoc;
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
		{
			source.clip = soundList[GetRandomSound(1)];
			source.Play();
		}
		else if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
			source.Stop();
    }
}
