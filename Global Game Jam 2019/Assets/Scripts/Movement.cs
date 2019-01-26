using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	public float moveSpeed = 2.0f;

	private GameObject player;
	private Rigidbody2D playerRigid;

    // Start is called before the first frame update
    void Start()
    {
		player = GameObject.FindGameObjectWithTag("Player");
		playerRigid = player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
		
    }

	// Movement update
	private void FixedUpdate()
	{

		//double inputs
		if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A)) {
			playerRigid.AddForce(new Vector2(-moveSpeed * 500.0f, moveSpeed * 500.0f));
		}
		else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D)){
			playerRigid.AddForce(new Vector2(moveSpeed * 500.0f, moveSpeed * 500.0f));
		}
		else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A)){
			playerRigid.AddForce(new Vector2(-moveSpeed * 500.0f, -moveSpeed * 500.0f));
		}
		else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D)){
			playerRigid.AddForce(new Vector2(moveSpeed * 500.0f, -moveSpeed * 500.0f));
		}
		else
		{
			//basic inputs
			if (Input.GetKey(KeyCode.W))
			{
				playerRigid.AddForce(new Vector2(0, moveSpeed * 1000.0f));
			}
			if (Input.GetKey(KeyCode.A))
			{
				playerRigid.AddForce(new Vector2(-moveSpeed * 1000.0f, 0));
			}
			if (Input.GetKey(KeyCode.S))
			{
				playerRigid.AddForce(new Vector2(0, -moveSpeed * 1000.0f));
			}
			if (Input.GetKey(KeyCode.D))
			{
				playerRigid.AddForce(new Vector2(moveSpeed * 1000.0f, 0));
			}
		}
	}
}
