using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateTracker : MonoBehaviour
{

	private GameObject player;
	private bool inHouseRange = false;
	public bool atHome = false;


    // Start is called before the first frame update
    void Start()
    {
		player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Space)) {
			Debug.Log("Pressed\n");
			//enters the house/leaves the house
			if (atHome) {
				//get in house animation goes here ... @anim
				Debug.Log("Out\n");
				player.GetComponent<SpriteRenderer>().enabled = true;
				atHome = false;
			}
			else if(inHouseRange){
				//leave house animation goes here ... @anim
				Debug.Log("In\n");
				player.GetComponent<SpriteRenderer>().enabled = false;
				atHome = true;
			}
		}
    }

	public void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "House")
		{
			inHouseRange = true;
		}
	}
	public void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "House")
		{
			inHouseRange = false;
		}
	}
}
