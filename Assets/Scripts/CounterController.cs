using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CounterController : MonoBehaviour {

	// Use this for initialization

	public float timeRemaining;
	private Text timerText;
	void Start () {
		timerText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update()
	{
		
		timeRemaining -= Time.deltaTime;
		if (timeRemaining > 0) {
			float minutes = Mathf.Floor (timeRemaining / 60);
			float seconds = Mathf.Floor (timeRemaining % 60);
			timerText.text = minutes.ToString ("00") + ":" + seconds.ToString ("00");
		} else {
			SceneManager.LoadScene ("GameOverScene", LoadSceneMode.Single);
		}

		if (Input.GetKey(KeyCode.Escape)){
			SceneManager.LoadScene ("GameOverScene", LoadSceneMode.Single);
		}
	}
}
