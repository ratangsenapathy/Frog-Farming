using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleGenerator : MonoBehaviour {

	public Terrain terrain;
	public GameObject turtle;
	public static int turtleCount;
	// Use this for initialization
	private Vector3 startCoordinate;
	private Vector3 endCoordinate;
	void Start () {
		startCoordinate =new Vector3 (terrain.transform.position.x+5.0f,terrain.transform.position.y,terrain.transform.position.z+5.0f);
		endCoordinate = new Vector3 (startCoordinate.x+40.0f,startCoordinate.y,startCoordinate.z+40.0f);
		Invoke ("GenerateTurtles", 0.5f);
	}
	
	// Update is called once per frame
	void GenerateTurtles () {
		if (turtleCount <= 10) {
			float x = Random.Range (startCoordinate.x, endCoordinate.x);
			float z = Random.Range (startCoordinate.z, endCoordinate.z);
			float y = startCoordinate.y + 3.0f;
			Vector3 spawnPoint = new Vector3 (x, y, z);
			Instantiate (turtle, spawnPoint, Quaternion.identity);
			turtleCount++;
		}
		Invoke ("GenerateTurtles", 3.0f);
	}
}
