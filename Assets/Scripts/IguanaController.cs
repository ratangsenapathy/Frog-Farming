using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IguanaController : MonoBehaviour {

	// Use this for initialization
	public float speed;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 oldPosition = transform.position;
		//Debug.Log (transform.right);
		transform.Translate(transform.forward*speed * Time.deltaTime,Space.World);
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Fence") {
			StartCoroutine (RotateMe (Vector3.up * 110, 4));
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
