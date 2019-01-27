using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arm : MonoBehaviour
{
	public GameObject self;
	public GameObject house;
	public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
		self = this.gameObject;
		house = GameObject.FindGameObjectWithTag("House");
		player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
		Vector3 pos = Vector3.Lerp(house.GetComponent<Transform>().position, player.GetComponent<Transform>().position, (float)0.5);
		self.transform.position = new Vector3(pos.x, pos.y, 0.0f);

		float rot_z = Mathf.Atan2(house.GetComponent<Transform>().position.y - player.GetComponent<Transform>().position.y, house.GetComponent<Transform>().position.x - player.GetComponent<Transform>().position.x) * Mathf.Rad2Deg;
		self.transform.rotation = Quaternion.Euler(0f, 0f, rot_z);
	}
}
