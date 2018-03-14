using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant_controller : MonoBehaviour {

	//for changing appereance depend on the type
	public GameObject[] Stages = new GameObject[3];

	//OOP Var will be handeld automaticly
	public int type;
	public float growthSpeed;
	public float age;
	public float LifeSpan;
	private Plants myPlants;

	// Use this for initialization
	void Start () {
		myPlants = new Plants();
		GetOOP();
	}
	
	// Update is called once per frame
	void Update () {
		Growing();
	}

	//the max age for now is 100 this will later be adjusted depend on the type and how old the object can get
	void Growing()
	{
		age = age + Time.deltaTime / LifeSpan;
		if (age <= 10)
		{
			
		}		
	}

	void GetOOP()
	{
		type = myPlants.type;
		growthSpeed = myPlants.GrowthSpeed;		
		LifeSpan = myPlants.LifeSpan;
	}

	void TypeController()
	{

	}
}
