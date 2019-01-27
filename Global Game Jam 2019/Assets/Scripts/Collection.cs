using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;



public class Collection : MonoBehaviour
{
	public float totalPoints;
	public List<int> collection;
	public AudioSource source;
	public Image meter;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
		meter.fillAmount = totalPoints / 25;
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{

		if (collision.gameObject.tag == "Collectable") {

			RewardData data = collision.gameObject.GetComponent<RewardData>();
			totalPoints += data.points;
			collection.Add(data.index);
			Debug.Log(totalPoints);
			Debug.Log("Happening/n");
			//collection anim goes here ... @anim
			
			//Collection sound
			source.Play();

			data.DeleteSelf();
		}
	}

}
