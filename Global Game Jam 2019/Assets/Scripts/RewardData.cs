using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewardData : MonoBehaviour
{

	public int points = 1;
	public int index = 0;


	public void DeleteSelf() {
		this.gameObject.SetActive(false);
	}
}
