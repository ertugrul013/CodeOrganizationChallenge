///made by ertugrul yesil
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plants{

	public float GrowthSpeed;
	public float LifeSpan;
	public float AgeMultiplier;
	public string[] type = new string [] {"Bush" , "Tree" , "Berry", "Boulder"};
	public string myType;

	public Plants()
	{
		myType = type[Random.Range(0,type.Length)].ToString();

		//bush
		if (myType == type[0])
		{
			GrowthSpeed = Random.Range(3,5);	
		}
		//tree
		else if (myType == type[1])
		{
			GrowthSpeed = Random.Range(0,3);
		}
		//Berry
		else if (myType == type[2])
		{
			GrowthSpeed = Random.Range(1,4);
		}
		//boulder
		else if (myType == type[3])
		{
			GrowthSpeed = Random.Range(0,0);
		}
		else
			Debug.LogWarning("I dont know how but you facked up");
	}		
	}

