using UnityEngine;
using System.Collections;

public class UI_PauseMenu : MonoBehaviour {

	public GameObject PauseMenu;
	public bool isPaused = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		PauseGame ();
		UnPauseGame ();
	}

	public void PauseGame(){
			
		if (Input.GetButton ("Pause") && !isPaused) {
			PauseMenu.SetActive (true);
			isPaused = true;
			//Time.timeScale = 0;
		}
	}

	public void UnPauseGame(){
		if (Input.GetButton ("Pause") && isPaused){
			PauseMenu.SetActive (false);
			isPaused = false;
			//Time.timeScale = 1;
		}
	}
		
}
