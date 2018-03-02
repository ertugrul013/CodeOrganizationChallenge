using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World_Maneger : MonoBehaviour {
	private Transform World_Scale;
	[Range(5,15)] public int WorldSize;

	private GameObject Food;
	[SerializeField][Range(5,10)] private float FoodScale;
	[SerializeField][Range(5,10)] private float ObsctaleScale;
	private GameObject Obstacle;
	// Use this for initialization
	void Start ()
	{
		World_Scale = this.gameObject.transform;
		World_Scale.localScale = new Vector3 (WorldSize, WorldSize, WorldSize);	
		Debug.Log(ReturnBorder());
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
		for (int i = 5; i < 16; i++)
		{
			if (i == WorldSize)
			{
				return( i * 5);
			}
		}
			return (1f);		
	}
}
