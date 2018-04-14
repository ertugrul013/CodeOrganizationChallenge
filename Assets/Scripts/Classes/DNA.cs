using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNA 
{
	public int isMale;
	public int type;

	public float hunger;
	public float speed;
	public float strength;
	public float health;
	public string tag;


//random ranges still need to be adjusted for the different types
	public DNA(int type)
	{
		isMale = Random.Range(0, 2);
		type = Random.Range(0, 3);
		this.type = type;

		switch (type)
		{
			case 0: //the vegan type
				hunger = Random.Range(60, 100);
				speed = Random.Range(3, 10);
				strength = Random.Range(40, 60);
				health = Random.Range(80, 100);
				tag = "Type" + type.ToString();
			break;
			
			case 1:
				hunger = Random.Range(65, 100);
				speed = Random.Range(3, 130);
				strength = Random.Range(45, 60);
				health = Random.Range(70, 100);
				tag = "Type" + type.ToString();
			break;

			case 2:
				hunger = Random.Range(70, 90);
				speed = Random.Range(3, 8);
				strength = Random.Range(20, 60);
				health = Random.Range(90, 100);
				tag = "Type" + type.ToString();
			break;
			
			default:
				Debug.Log("IF YOU GOT HERE YOU DID SOMETHING WRONG NOT ME YOU");
			break;
		}
	}

}

