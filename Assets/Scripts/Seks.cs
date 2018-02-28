using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seks : MonoBehaviour {

	public GameObject prefab1;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Creature1")
		{
			instanciate ()
		} 
	}
}
