using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature_Manager : MonoBehaviour {
	
	private DNA MyDNA;

	public Material[] GenderMat;
	 
	private int amountOfHealth;
	private float strenght;
	private float foodDecrease;

	public Vector3 target;

	public Transform TempFoodSource;

	public Transform carcassPrefab;
	
	public float distance;

	private float border;

	//oop var
	[SerializeField]private int isMale;
	[SerializeField]private int type;

	[SerializeField]private float hunger;
	[SerializeField]private float speed;
	[SerializeField]private float strength;
	[SerializeField]private float health;
	

// Use this for initialization
	void Start () 
	{
		foodDecrease = 0.1f;
		speed = 5f;
		hunger = 10f;
		border = GameObject.Find("World").GetComponent<World_Maneger>().ReturnBorder();
		MyDNA = new DNA(type);
		OOPVar();
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
	
#region WIP Food manegmend

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
#endregion
//restores hunger
	void Eating() 
	{
		for (int i = 0; i <= 10; i++)
        {
            hunger++;
        }
		DestroyFoodSource();
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

//Destroys foodsource after its been eaten
	void DestroyFoodSource()
	{
		Destroy(TempFoodSource);
	}

//Detects collision for when its hungry 
	void OnCollisionEnter (Collision col)
    {
     	if (type == 0 && hunger <= 2f)
		{
			if (col.gameObject.tag == "Tree" || col.gameObject.tag == "Bush" || col.gameObject.tag == "Berry")
      		{
     		    target = col.transform.position;
				TempFoodSource = col.gameObject.transform;
			}
   		}
		else if (type == 1 && hunger <= 2f)
		{
			if (col.gameObject.tag == "Carcass")
			{
				target = col.transform.position;
				TempFoodSource = col.gameObject.transform;
			}
		}
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