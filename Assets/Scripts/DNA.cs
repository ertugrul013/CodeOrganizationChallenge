using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNA {

	bool isMale;
	int friendliness;
	int amountOfHealth;
	float foodDetectionDistance;
	int age;
	float strenth;
	float speed; 
	string type;
	float hungerSpeed;


#region Gender Decide
	public bool Gender()
	{
		int Choose  = Random.Range(0,1);

		if (Choose > 0.5)
		{
			return false;
		}
		else if (Choose =< 0.5) 
		{
			return true;
		}
		else
		{
			Debug.Log("YOU FACKED UP BOI");
		}
	}
#endregion

x
}
