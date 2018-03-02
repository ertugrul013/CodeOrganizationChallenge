using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature_Manager : MonoBehaviour {
	
	public Material[] GenderMat;
	 
	private int amountOfHealth;
	private float strenght;
	private float speed;
	public float hunger;
	private float foodDecrease;

	public Vector3 target;

	public Transform leavesPrefab;
	public Transform carcassPrefab;
	public float distance;

	private float border;
	

// Use this for initialization
	void Start () 
	{
		foodDecrease = 0.1f;
		speed = 5f;
		hunger = 10f;
		border = GameObject.Find("World").GetComponent<World_Maneger>().ReturnBorder();
	}
	
// Update is called once per frame
	void Update () 
	{
//Decreases hunger and dies if hunger hits 0
		hunger -= foodDecrease * Time.deltaTime;
		
		if (hunger <= 0f)
		{
			SpawnCarcass();
		}


		float mSpeed = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, target, mSpeed);

//sets new target when position is reached
		if (transform.position == target) 
		{
			TarUpdate();
		}

//checks distance between creature and foodsource then changes target to nearest foodsource based on creatures tpye
		/*if (type == 1)
		{
			distance = Vector3.Distance(transform.position, LeavesPrefab.transform.position);
		} 
		else if (type == 0)
		{
			distance = Vector3.Distance(transform.position, carcassPrefab.transform.position);
		}
		if (distance < 10f && hunger <= 2f)
		{
			target = food.transform.position;
			if (transform.position == target)
			{
				Eating();	
			}
		} 
		*/
	}

//restores hunger
	void Eating() 
	{
		for (int i = 0; i <= 10; i++)
        {
            hunger++;
        }
		TarUpdate();
	}

//sets new target after position has been reached or if hunger has been restored
	void TarUpdate() 
	{
		target = new Vector3(Random.Range(border, -border), 0.8f, Random.Range(border, -border));
	}

//spawns meat carcass at position when creature dies
	void SpawnCarcass()
	{
		Instantiate(carcassPrefab, transform.position, Quaternion.identity);
		Destroy(gameObject);
	}


}