using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleController : MonoBehaviour {

	// Use this for initialization
	public float landSpeed;
	public float waterSpeed;

	private float speed;
	private Rigidbody rb;
	void Start () {
		rb = GetComponent<Rigidbody> ();
		speed = 0.02f;
	}
	
	float m_distanceTraveled = 0.0f;

	void Update() {
		if (m_distanceTraveled < 100f) {
			Vector3 oldPosition = transform.position;
			Debug.Log (transform.right);
			transform.Translate(-transform.right*speed * Time.deltaTime);
			m_distanceTraveled += Vector3.Distance(oldPosition, transform.position);
		}
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Fence") {
			
		}
	}
}
