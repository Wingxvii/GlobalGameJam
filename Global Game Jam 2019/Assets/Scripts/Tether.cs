using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tether : MonoBehaviour
{

	public float minDist = 2.0f;
	public float maxDist = 4.0f;
	public float moveSpeed = 1.6f;

	private GameObject target;
	private GameObject self;
	private Rigidbody2D localRigid;
	private Vector2 dir;


    // Start is called before the first frame update
    void Start()
    {
		target = GameObject.FindGameObjectWithTag("Player");
		self = GameObject.FindGameObjectWithTag("House");
		localRigid = self.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
		dir = target.GetComponent<Transform>().position - self.GetComponent<Transform>().position;
		dir.Normalize();
    }

	private void FixedUpdate()
	{	//moves if out of min distance
		if ((self.GetComponent<Transform>().position - target.GetComponent<Transform>().position).magnitude > minDist) {
			localRigid.AddForce(moveSpeed*500.0f*dir);
		}
		//keeps up with player max range
		if ((self.GetComponent<Transform>().position - target.GetComponent<Transform>().position).magnitude > maxDist) {
			self.GetComponent<Transform>().position = target.GetComponent<Transform>().position - new Vector3((dir * maxDist).x, (dir * maxDist).y, 0.0f);
		}

	}
}
