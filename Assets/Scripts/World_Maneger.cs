using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World_Maneger : MonoBehaviour {
	private Transform World_Scale;
	[Range(5,15)] public int WorldSize;

	private GameObject Food;
	private GameObject Obstacle;
	// Use this for initialization
	void Start ()
	{
		World_Scale = this.gameObject.transform;
		World_Scale.localScale = new Vector3 (WorldSize, WorldSize, WorldSize);	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void FoodSpawn()
	{

	}

	float ReturnBorder()
	{
		for (int i = 5; i < 15; i++)
		{
			if (i == WorldSize)
			{
				return(i * 5);
			}
		}
		return(0);
	}
}
