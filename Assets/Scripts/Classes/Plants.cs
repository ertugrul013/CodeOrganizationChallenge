///made by ertugrul yesil

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plants{

	public float GrowthSpeed;
	public string[] type = new string [] {"Bush" , "Tree" , "Berry"};
	public string myType;

	public Plants()
	{
		myType = type[Random.Range(0,type.Length)].ToString();

		if (myType === type[0])
		{
			GrowthSpeed = 	
		}
		else if (myType === type[1])
		{
			
		}
		else if (myType === type[2])
		{
			
		}
		else
			Debug.LogWarning("I dont know how but you facked up");
	}		
	}
}
