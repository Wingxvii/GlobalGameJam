using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
	public GameObject player;
	public GameObject house;
	private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
		offset = transform.position - player.transform.position;
    }

	// Update is called once per frame
	private void Update()
	{
		if (player.transform.position.x < -10)
		{
			player.transform.position = new Vector3(10f, player.transform.position.y, 0f);
			house.transform.position = new Vector3(11.68f, house.transform.position.y, 0f);
		}
		else if (player.transform.position.x > 10)
		{
			player.transform.position = new Vector3(-10f, player.transform.position.y, 0f);
			house.transform.position = new Vector3(-11.68f, house.transform.position.y, 0f);
		}
		if (player.transform.position.y > 10)
		{
			player.transform.position = new Vector3(player.transform.position.x, -10f, 0f);
			house.transform.position = new Vector3(house.transform.position.x, -11.68f, 0f);
		}
		else if (player.transform.position.y < -10)
		{
			player.transform.position = new Vector3(player.transform.position.x, 10f, 0f);
			house.transform.position = new Vector3(house.transform.position.x, 11.68f, 0f);
		}
	}

	void LateUpdate()
    {
		//if (player.transform.position.y >= offset.y * 2)
		//{
			transform.position = player.transform.position + offset;
		//}
	}
}
