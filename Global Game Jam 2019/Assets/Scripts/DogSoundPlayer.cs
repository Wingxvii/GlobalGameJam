using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogSoundPlayer : MonoBehaviour
{
	public AudioSource sourceDog;
	public List<AudioClip> soundList;
	bool isSoundPlaying = false;
	float timer = 10;

	int GetRandomSound(int soundType)
	{
		int soundLoc = 0;

		if (soundType == 1)
			soundLoc = Random.Range(0, 6);

		return soundLoc;
	}

	void PlaySound(AudioClip audioClip)
	{
		isSoundPlaying = true;
		if (timer <= 0)
		{
			sourceDog.Play();
			timer = 10;
		}
	}

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (!sourceDog.isPlaying)
		{
			isSoundPlaying = false;
		}

		timer -= Time.deltaTime;

		//Play a dog bark
		if (isSoundPlaying == false)
		{
			sourceDog.clip = soundList[GetRandomSound(1)];
			PlaySound(sourceDog.clip);
		}
	}
}
