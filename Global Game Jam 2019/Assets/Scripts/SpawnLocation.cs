using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLocation : MonoBehaviour
{

	public Vector3 pos;
	public bool isOutRange;
	private Transform player;
	public float range = 4.0f;



    // Start is called before the first frame update
    void Start()
    {
		pos = this.GetComponent<Transform>().position;
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

	private void Update()
	{
		if ((pos - player.position).magnitude > range)
		{

			isOutRange = true;
		}
		else {
			isOutRange = false;
		}
	}
}
