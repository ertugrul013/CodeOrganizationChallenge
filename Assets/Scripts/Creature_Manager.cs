using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Creature_Manager : MonoBehaviour {
	// private enum State
	// {
	// 	hungery,
	// 	alive,
	// 	horny
	// };

	// private State state;

	private DNA MyDNA;

	public Material[] GenderMat;
	public GameObject[] bodyTypes;
	 
	private int amountOfHealth;
	private float strenght;
	private float foodDecrease;

	private Vector3 target;

	private float border;

	private float FovObstacle = 115f;
	private float FovFood = 180f;

	//oop var
	private int isMale;
	private int type;

	public float hunger;
	private float speed;
	private float strength;
	private float health;

	public GameObject Parent;

	// Use this for initialization
	void Start () 
	{
		foodDecrease = 0.1f;
		speed = 5f;
		border = GameObject.Find("World").GetComponent<World_Maneger>().ReturnBorder();
		MyDNA = new DNA(type);
		OOPVar();
		Parent = GameObject.Find("Type " + type.ToString()).gameObject;
		
		// //threading
		// ThreadStart st = new ThreadStart(ObstacleAviod);
		// Thread t =  new Thread(st);
		// t.Start();

	}
	
	// Update is called once per frame
	void Update () 
	{
		//Decreases hunger and dies if hunger hits 0
		hunger -= foodDecrease * Time.deltaTime;
		
		if (hunger <= 0f)
		{
			Destroy(this.gameObject);
		}

		transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

		//sets new target when position is reached
		if (transform.position == target) 
		{
			TarUpdate();
		}
	}
	//restores hunger
	void FoodFinding() 
	{		
		RaycastHit hit;
		Vector3 direction = target - transform.position;
		// Debug.DrawRay(transform.position,direction , Color.red);
		if (Physics.Raycast(transform.position,direction ,out hit))
		{
			if (hit.transform.gameObject.CompareTag("Food"))
			{
				float angle = Vector3.Angle(transform.forward, direction);
				if (angle < FovFood / 2)
				{
					target = hit.transform.position;
				}
				else
				{
					Debug.Log("IT IS OUT OF RANGE");
				}
			}
		
		}
	}

	//sets new target after position has been reached or if hunger has been restored
	void TarUpdate() 
	{
		target = new Vector3(Random.Range(border, -border), 0.8f, Random.Range(border, -border));
		this.transform.LookAt(target);
		
	}

	void ObstacleAviod()
	{
		
	}
	void OOPVar()
	{
		isMale = MyDNA.isMale;
		type = MyDNA.type;
		hunger = MyDNA.hunger;
		speed = MyDNA.speed;
		strength = MyDNA.strength;
		health = MyDNA.health;

		if (isMale == 0)
		{
			GetComponent<MeshRenderer>().material = GenderMat[0];
		}
		else
		{
			GetComponent<MeshRenderer>().material = GenderMat[1];
		}
	}

}