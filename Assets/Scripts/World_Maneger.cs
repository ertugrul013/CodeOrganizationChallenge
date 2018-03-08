using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World_Maneger : MonoBehaviour {
	[Header("World Settings")]
	private Transform World_Scale;
	[Range(5,50)] public int WorldSize;

	[Space][Header("Creatur Settings")]
	[SerializeField] private GameObject Creatur;
	[Tooltip("this should be an even number")][SerializeField] private int AmountOfCreaturs;

	[Space]
	[Header("Spawnable Objects")]
	public GameObject Food;
	[SerializeField][Range(5,40)] private int FoodScale;

	[Space]
	public GameObject Plants;
	[SerializeField][Range(5,20)] private int PlantsScale;

	private float borderpos;
	// Use this for initialization
	void Start ()
	{
		World_Scale = this.gameObject.transform;
		World_Scale.localScale = new Vector3 (WorldSize, WorldSize, WorldSize);	
		borderpos = ReturnBorder();

		ObjectSpawn();
		InitSpawn();


	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void ObjectSpawn()
	{
		for (int i = 0; i < 5 * PlantsScale; i++)
		{	
			Instantiate (Plants,new Vector3(Random.Range(borderpos, -borderpos), 0.5f, Random.Range(borderpos, -borderpos)),Quaternion.identity);
		}
		for (int i = 0; i < 5 * FoodScale; i++)
		{
			Instantiate (Food,new Vector3(Random.Range(borderpos, -borderpos), 0.5f, Random.Range(borderpos, -borderpos)),Quaternion.identity);
		}
	
	}

	//will calculate the world borders but only if the world object is a plane
	public float ReturnBorder()
	{
		for (int i = 5; i < WorldSize ; i++)
		{
			if (i == WorldSize)
			{				
				borderpos = i * 5;
				return( i * 5);
			}
			//if you maxed the slider it will fallback to adding 1 to i and trying it again
			else
			{
				i++;
				if (i == WorldSize)
				{
					borderpos = i * 5;
					return(i * 5);
				}
			}
		}
			return (1f);		
	}

	void InitSpawn()
	{
		int temp = AmountOfCreaturs % 2;
		if(temp == 0){
			for (int x = 0; x < AmountOfCreaturs; x++)
			{
				Vector3 posx = new Vector3 (0, x,0.5f);
				Instantiate(Creatur,posx , Quaternion.identity);
			}	
		}
		else
			Debug.LogError("Not an even number");
			return;
	}
}
