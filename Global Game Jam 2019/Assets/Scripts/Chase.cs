using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{

	private Transform player;
	private Transform monster;
	private StateTracker playerState;

	public float lookRange;

	private Vector2 dir;
	public float speed = 2;

	public int stopTime = 50;
	private int stopTimeActual;

	public float stopRatio = 2.0f;

	private Rigidbody2D monsterRigid;

	public AudioSource source;
	public List<AudioClip> soundList;


	// Start is called before the first frame update
	void Start()
    {
		stopTimeActual = (int)Random.Range(0, stopTime);
		dir = new Vector2(Random.value, Random.value);
		dir.Normalize();
		monsterRigid = this.GetComponent<Rigidbody2D>();
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
		monster = this.GetComponent<Transform>();
		playerState = GameObject.FindGameObjectWithTag("Player").GetComponent<StateTracker>();

	}

	int GetRandomSound(int soundType)
	{
		int soundLoc = 0;

		if (soundType == 1)
			soundLoc = Random.Range(0, 3);

		return soundLoc;
	}

	void PlaySound(AudioClip audioClip)
	{
		source.Play();
	}

	public void Update()
	{
		if ((player.position - monster.position).magnitude < lookRange && !playerState.atHome) {
			dir = (player.position - monster.position).normalized;
			stopTimeActual = 10;
			monsterRigid.AddForce(dir * speed * 1000.0f);
		}
	}

	private void OnBecameVisible()
	{
		//Play a monster sound
		source.clip = soundList[GetRandomSound(1)];
		PlaySound(source.clip);
	}

	private void FixedUpdate()
	{
		stopTimeActual--;

		if (stopTimeActual == 0)
		{
			dir = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));
			dir.Normalize();
		}

		if (stopTimeActual < 0) {
			monsterRigid.AddForce(dir * speed * 1000.0f);
		}
		if (stopTimeActual == (int)(-stopTime*stopRatio)) {
			stopTimeActual = stopTime;
		}

	}


}
