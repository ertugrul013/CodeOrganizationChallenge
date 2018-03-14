//vraag even aan david of het slimmer is om alle variable op het begin op te vragen 
// of pas wanneer je ze nog gaat hebben
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant_controller : MonoBehaviour {
	[Header("types in prefab form")]
	public GameObject[] GameObjectTypes = new GameObject[3];
	
	[Space]
	[Header("stage deppend on the tpye")]
	//for changing appereance depend on the type
	public GameObject[] Tree = new GameObject[4];
	public GameObject[] Bush = new GameObject[2];

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
		DestroyUnused();
		switch (type)
		{
			case 0:
				GameObjectTypes[0].SetActive(true);
			break;
			case 1:
				GameObjectTypes[1].SetActive(true);
				break;
			case 2:
				GameObjectTypes[2].SetActive(true);
			break;
			
			default:
				Debug.Log("well either you or me facked up. lets just say you facked up");
			break;
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		GrowingControl();
	}

	//the max age for now is 100 this will later be adjusted depend on the type and how old the object can get
	void GrowingControl()
	{
		age = age + Time.deltaTime / LifeSpan;
		if(type == 0)
		{
			GrowingType1();
		}
		else
		{
			GrowingType2();
		}

		if (age > 40)
		{
			GameObject.Find("World").GetComponent<World_Maneger>().SpawnObject();
			Destroy(this.gameObject);
		}
			
	}

	void GetOOP()
	{
		type = myPlants.type;
		growthSpeed = myPlants.GrowthSpeed;		
		LifeSpan = myPlants.LifeSpan;
	}

	void GrowingType1()//tree
	{
		if(Tree[0] != null)
		{
			if (age <= 10)
			{
				Tree[0].SetActive(true);
			}
			if (age >= 10)
			{
				Tree[1].SetActive(true);
			}
			if (age >= 15)
			{
				Tree[2].SetActive(true);
			}
			if (age >= 20)
			{
				Tree[3].SetActive(true);
			}
		}else
			return;
	}

	void GrowingType2()//bush berry
	{
		if(Bush[0] != null)
		{
			if(age <= 5)
			{
				Bush[0].SetActive(true);
			}
			else
			{
				Bush[1].SetActive(true);
			}
		}else
			return;
	}
	void DestroyUnused()
	{
		if (type == 0)
		{
			Destroy(GameObjectTypes[1]);
			Destroy(GameObjectTypes[2]);
		}
		else if (type == 1)
		{
			Destroy(GameObjectTypes[0]);
			Destroy(GameObjectTypes[2]);
		}
		else
		{
			Destroy(GameObjectTypes[0]);
			Destroy(GameObjectTypes[1]);
		}
	}

}
