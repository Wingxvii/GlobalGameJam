using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class StateTracker : MonoBehaviour
{

	private GameObject player;
	private GameObject home;
	public AudioSource source;
	public bool inHouseRange = false;
	public bool atHome = false;
	public bool isDead = false;

	public List<AudioClip> stateClips;

	public Button settleButton;
	float timer = 0;

	//public PresentScene presentScene;


	// Start is called before the first frame update
	void Start()
    {
		player = GameObject.FindGameObjectWithTag("Player");
		home = GameObject.FindGameObjectWithTag("House");
    }

    // Update is called once per frame
    void Update()
    {
		timer += Time.deltaTime;
		if (Input.GetKeyDown(KeyCode.Space)) {
			Debug.Log("Pressed\n");
			//enters the house/leaves the house
			if (atHome) {
				//leave house animation goes here ... @anim
				
				//Turn off music filter
				GameObject.FindGameObjectWithTag("BKGMusic").GetComponent<AudioLowPassFilter>().enabled = false;
				
				//Play leave house sound
				source.clip = stateClips[1];
				source.Play();

				//Hide button to settle down the house
				//settleButton.transform.localPosition = new Vector3(0f, -50f, 0f);
				settleButton.transform.Translate(0f, -130f, 0f);
				//settleButton.transform.position = new Vector3(0f, -50f, 0f);

				Debug.Log("Out\n");
				player.GetComponent<SpriteRenderer>().enabled = true;
				player.GetComponent<Transform>().position = home.GetComponent<Transform>().position;
				player.GetComponent<CapsuleCollider2D>().enabled = true;

				atHome = false;
			}
			else if(inHouseRange){
				//get in house animation goes here ... @anims
				
				//Filter music when in house
				GameObject.FindGameObjectWithTag("BKGMusic").GetComponent<AudioLowPassFilter>().enabled = true;
				
				//Play enter house sound
				source.clip = stateClips[0];
				source.Play();

				//Show the button to settle down the house
				//settleButton.transform.localPosition = new Vector3(0f, 60f, 0f);
				settleButton.transform.Translate(0f, 130f, 0f);
				//settleButton.transform.position = new Vector3(0.0f, 60f, 0f);

				Debug.Log("In\n");
				player.GetComponent<SpriteRenderer>().enabled = false;
				player.GetComponent<CapsuleCollider2D>().enabled = false;

				atHome = true;
			}
		}

		if (timer >= 1 && isDead == true)
			GameObject.FindGameObjectWithTag("SceneManagement").GetComponent<PresentScene>().SwapScene(4);
	}

	public void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "House")
		{
			inHouseRange = true;
		}

	}

	public void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Monster" && !atHome)
		{
			Debug.Log("Dead");
			//Play leave house sound
			source.clip = stateClips[2];
			source.Play();
			isDead = true;
			timer = 0;
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
