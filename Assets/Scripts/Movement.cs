using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public float speed;

	public Vector3 target;
	

	// Use this for initialization
	void Start () 
	{
		target = new Vector3(Random.Range(23f, -23f), transform.position.y, Random.Range(23f, -23f));
	}
	
	// Update is called once per frame
	void Update () 
	{
		float mSpeed = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, target, mSpeed);

		if (transform.position == target)
		{
			target = new Vector3(Random.Range(23f, -23f), transform.position.y, Random.Range(23f, -23f));
		}
	}
}
