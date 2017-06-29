using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleGenerator : MonoBehaviour {

	public Terrain terrain;
	// Use this for initialization
	private Vector3 startCoordinate;
	private Vector3 endCoordinate;
	void Start () {
		startCoordinate = terrain.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
