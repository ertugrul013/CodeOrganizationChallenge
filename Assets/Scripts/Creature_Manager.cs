using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature_Manager : MonoBehaviour {

	private int amountOfHealth;
	private float Strenght;
	private float speed;
	public float hunger;
	private float foodDecrease;

	public Vector3 target;

	public Transform food;
	public float distance;
	

	// Use this for initialization
	void Start () 
	{
		foodDecrease = 0.1f;
		speed = 5f;		
	}
	
	// Update is called once per frame
	void Update () 
	{
		hunger -= foodDecrease * Time.deltaTime;

		distance = Vector3.Distance(transform.position, food.transform.position);
		
		
		
		
		float mSpeed = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, target, mSpeed);

		if (transform.position == target)
		{
			target = new Vector3(Random.Range(23f, -23f), transform.position.y, Random.Range(23f, -23f));
		}

		if (distance < 10f && hunger <= 1f)
		{
			target = food.transform.position;
			if(transform.position == target)
			{
				Eating();	
			}
		}
	}

	void Eating()
	{
		for (int i = 0; i <= 10; i++)
        {
            hunger++;
        }
		PosUpdate();
	}

	void PosUpdate()
	{
		target = new Vector3(Random.Range(23f, -23f), transform.position.y, Random.Range(23f, -23f));
	}
}
