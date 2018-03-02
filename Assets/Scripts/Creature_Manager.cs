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

	private float Border;
	

	// Use this for initialization
	void Start () 
	{
		foodDecrease = 0.1f;
		speed = 5f;		
		Border = GameObject.Find("World").GetComponent<World_Maneger>().ReturnBorder();
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
			target = new Vector3(Random.Range(Border, -Border), transform.position.y, Random.Range(Border, -Border));
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
		target = new Vector3(Random.Range(Border, -Border), transform.position.y, Random.Range(Border, Border));
	}
}
