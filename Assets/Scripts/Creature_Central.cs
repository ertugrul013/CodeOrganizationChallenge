using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature_Central : MonoBehaviour {

	public static Creature_Central instance;

	List<GameObject> Creatures_Type0;
	List<GameObject> Creatures_Type1;
	List<GameObject> Creatures_Type2;

	void Awake()
	{
		if (instance == null)
		{
			instance = this;
		}else
		{
			Destroy(this);
		}
	}

	// Use this for initialization
	void Start () {
		Creatures_Type0 = new List<GameObject>();
		Creatures_Type1 = new List<GameObject>();
		Creatures_Type2 = new List<GameObject>();


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
