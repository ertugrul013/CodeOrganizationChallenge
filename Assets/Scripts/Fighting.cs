using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighting : MonoBehaviour {

	float health;
	float strenght;

	// Use this for initialization
	void Start () {
		health = Random.Range(1f, 11f);
		strenght = Random.Range(1f, 11f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision Col)
	{
		if (col.gameObject.tag == "OtherCreature")
		{
			
		}
	}
}
