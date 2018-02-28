using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public float speed;

	public Vector3 target;

	public Transform food;

	public float hunger;

	private float foodDecrease;

	public float distance;
	

	// Use this for initialization
	void Start () 
	{
		hunger = 10f;
		foodDecrease = 0.4f;

		target = new Vector3(Random.Range(23f, -23f), transform.position.y, Random.Range(23f, -23f));
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
				Start();	
			}
		}
	}
}
