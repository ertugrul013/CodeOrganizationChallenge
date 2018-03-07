using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World_Maneger : MonoBehaviour {
	[Header("World Settings")]
	private Transform World_Scale;
	[Range(5,15)] public int WorldSize;

	[Space][Header("Creatur Settings")]
	[SerializeField] private GameObject Creatur;
	[Tooltip("this should be an even number")][SerializeField] private int AmountOfCreaturs;

	[Space]
	[Header("Object Var")]
	public GameObject Food;
	[SerializeField][Range(5,10)] private float FoodScale;

	[Space]
	public GameObject Obstacle;
	[SerializeField][Range(5,10)] private float ObsctaleScale;
	

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
		for (int i = 0; i < 5 * ObsctaleScale; i++)
		{	
			Instantiate (Obstacle,new Vector3(Random.Range(borderpos, -borderpos), 0.5f, Random.Range(borderpos, -borderpos)),Quaternion.identity);
		}
		for (int i = 0; i < 5 * FoodScale; i++)
		{
			Instantiate (Food,new Vector3(Random.Range(borderpos, -borderpos), 0.5f, Random.Range(borderpos, -borderpos)),Quaternion.identity);
		}
	
	}

	public float ReturnBorder()
	{
		for (int i = 5; i < 16; i++)
		{
			if (i == WorldSize)
			{				
				borderpos = i * 5;
				return( i * 5);
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
