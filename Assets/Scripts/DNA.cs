/*
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
	bool type;
	float hungerSpeed;


#region Gender Decide
	public bool Gender()
	{
		float Choose  = Random.Range(0, 1);

		if (Choose > 0.5)
		{
			return false;
		}
		else if (Choose <= 0.5) 
		{
			return true;
		}
		else
		{
			Debug.Log("gender couldnt be decided");
			return false;
		}
	}
#endregion

#region type Decide
	public bool Types ()
	{
		float t  = Random.Range(0, 1);

		if (t > 0.5)
		{
			return false;
		}
		else if (t <= 0.5)
		{
			return true;
		}
		else
		{
			Debug.Log("no type could be assigend");
			return false;
		}
	}
#endregion

	public  int foodDetecet(int friend, int amountHealth)
	{
		int  detec = foodDetectionDistance;
		friend = friendliness;
		amountOfHealth = amountHealth;

		

		return(detec);
	}
 

}
*/
