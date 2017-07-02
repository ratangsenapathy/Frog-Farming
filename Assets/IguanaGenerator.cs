using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IguanaGenerator : MonoBehaviour {

	public Terrain terrain;
	public GameObject iguana;
	public static int iguanaCount;
	// Use this for initialization
	private Vector3 startCoordinate;
	private Vector3 endCoordinate;
	void Start () {
		startCoordinate =new Vector3 (terrain.transform.position.x+5.0f,terrain.transform.position.y,terrain.transform.position.z+5.0f);
		endCoordinate = new Vector3 (startCoordinate.x+40.0f,startCoordinate.y,startCoordinate.z+40.0f);
		Invoke ("GenerateIguanas", 0.5f);
	}

	// Update is called once per frame
	void GenerateIguanas () {
		if (iguanaCount <= 20) {
			float x = Random.Range (startCoordinate.x, endCoordinate.x);
			float z = Random.Range (startCoordinate.z, endCoordinate.z);
			float y = startCoordinate.y + 3.0f;
			Vector3 spawnPoint = new Vector3 (x, y, z);
			Instantiate (iguana, spawnPoint, Quaternion.identity);
			iguanaCount++;
		}
		Invoke ("GenerateIguanas", 3.0f);
	}
}
