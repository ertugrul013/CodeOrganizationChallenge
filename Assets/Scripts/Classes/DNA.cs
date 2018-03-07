using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNA 
{
	//variables to take care of
	public int isMale;
	public int type;

	public float hunger;
	public float speed;
	public float strength;
	public float health;



	public DNA(int type)
	{
		isMale = Random.Range(0,2);
		type = Random.Range(0,2);
		this.type = type;

		switch (type)
		{
			case 0: //the vegan type
				hunger = Random.Range(60,100);
				speed = Random.Range(5,10);
				strength = Random.Range(40,60);
				health = Random.Range(80,100);
			break;
			
			case 1:
				hunger = Random.Range(65,100);
				speed = Random.Range(8,10);
				strength = Random.Range(45,60);
				health = Random.Range(70,100);
			break;
			
			default:
				Debug.Log("IF YOU GOT HERE YOU DID SOMETHING WRONG NOT ME YOU");
			break;
		}
	}

}

