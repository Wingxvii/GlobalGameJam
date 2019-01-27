using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
	public AudioSource source;
	public List<AudioClip> soundList;

	bool isSoundPlaying = false;

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
			soundLoc = Random.Range(0, 6);
		}

		return soundLoc;
	}

	void PlaySound(AudioClip audioClip)
	{
		//float theTime = 0f;
		isSoundPlaying = true;
		source.Play();
		//theTime = Time.;
		//Debug.Log(source.clip.length);
		//if (theTime >= source.clip.length)
	}

	// Update is called once per frame
	void Update()
	{
		if (!source.isPlaying)
		{
			isSoundPlaying = false;
		}

		if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
		{
			if (isSoundPlaying == false)
			{
				source.clip = soundList[GetRandomSound(1)];
				PlaySound(source.clip);
			}
		}

		//double inputs
		if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
		{
			if (isSoundPlaying == false)
			{
				source.clip = soundList[GetRandomSound(1)];
				PlaySound(source.clip);
			}
		}
		else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
		{
			if (isSoundPlaying == false)
			{
				source.clip = soundList[GetRandomSound(1)];
				PlaySound(source.clip);
			}
		}
		else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
		{
			if (isSoundPlaying == false)
			{
				source.clip = soundList[GetRandomSound(1)];
				PlaySound(source.clip);
			}
		}
		else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
		{
			if (isSoundPlaying == false)
			{
				source.clip = soundList[GetRandomSound(1)];
				PlaySound(source.clip);
			}
		}
		//else if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
		//source.Stop();
	}
}
