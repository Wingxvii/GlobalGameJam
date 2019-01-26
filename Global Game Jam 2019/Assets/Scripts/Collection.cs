using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Collection : MonoBehaviour
{
	public int totalPoints;
	public List<int> collection;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{


		if (collision.gameObject.tag == "Collectable") {

			RewardData data = collision.gameObject.GetComponent<RewardData>();
			totalPoints += data.points;
			collection.Add(data.index);	
			Debug.Log("Happening/n");
			//collection anim goes here ... @anim
			data.DeleteSelf();
		}
	}

}
