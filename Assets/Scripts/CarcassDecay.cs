using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarcassDecay : MonoBehaviour {

	public float decayTime;

	// Use this for initialization
	void Start () {
		decayTime = 20f;
	}
	
	// Update is called once per frame
	void Update () {
		decayTime -= Time.deltaTime;
		
		if (decayTime <= 0)
		{
			Destroy(gameObject);
		}
	}
}
