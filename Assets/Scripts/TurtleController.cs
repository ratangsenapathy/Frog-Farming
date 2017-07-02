using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleController : MonoBehaviour {

	// Use this for initialization
	public float speed;

	//private float speed;
	//private Rigidbody rb;
	void Start () {
		//rb = GetComponent<Rigidbody> ();
	}
	


	void Update() {
		//Debug.Log (transform.rotation);
//		if (transform.rotation.y > 45) {
//			transform.rotation = Quaternion.Euler (new Vector3 (transform.rotation.x,0.0f,transform.rotation.z));
//		}
			Vector3 oldPosition = transform.position;
			//Debug.Log (transform.right);
			transform.Translate(-transform.right*speed * Time.deltaTime,Space.World);
			//m_distanceTraveled += Vector3.Distance(oldPosition, transform.position);
		
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Fence") {
			StartCoroutine (RotateMe (Vector3.up * 30, 10));
		}
	}

	IEnumerator RotateMe(Vector3 byAngles, float inTime) {
		var fromAngle = transform.rotation;
		var toAngle = Quaternion.Euler(transform.eulerAngles + byAngles);
		for(var t = 0f; t < 1; t += Time.deltaTime/inTime) {
			transform.rotation = Quaternion.Lerp(fromAngle, toAngle, t);
			yield return null;
		}
	}
}
