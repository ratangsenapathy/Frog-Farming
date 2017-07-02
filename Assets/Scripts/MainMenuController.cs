using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

	void Start(){
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
	}

	public void GoToGameScene(){
		SceneManager.LoadScene ("GameScene", LoadSceneMode.Single);
	}

	void Update(){
		if (Input.GetKey(KeyCode.Escape)){
			Application.Quit ();
		}

	}
}
