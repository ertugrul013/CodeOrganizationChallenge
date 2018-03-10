using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Plant_controller : MonoBehaviour {

	//for changing appereance depend on the type
	public GameObject[] Stages = new GameObject[5];

	//OOP Var will be handeld automaticly
	private float growthSpeed;
	public float age;
	private float LifeSpan;
	private float ageMultiplier;
	private Plants myPlants;

	// Use this for initialization
	void Start () {
		ageMultiplier = 2;
	}
	
	// Update is called once per frame
	void Update () {
		Growing();
	}

	//the max age for now is 100 this will later be adjusted depend on the type and how old the object can get
	void Growing()
	{
		age = age + Time.deltaTime * ageMultiplier;		
	}
}
