//author: Nathan McClain
//Credit: http://www.thegamecontriver.com/2014/10/create-sliding-pause-menu-unity-46-gui.html
//For: UB COSC 315: Kelso's Colors

using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]

public class FailPauseMenuScript : MonoBehaviour {
	//refrence for the pause menu panel in the hierarchy
	public GameObject pauseMenuPanel;
	public KeyCode pauseButton;  //allows us to assign pausebutton key from within Unity
	public AudioSource PauseSound; //allows us to assign pauseSound from within Unity
	public AudioSource UnPauseSound;
	//animator reference
	private Animator anim;
	//variable for <span id="IL_AD3" class="IL_AD">checking</span> if the game is paused 
	private bool isPaused = false;
	// Use this for initialization
	void Start () {
		//unpause the game on start
		Time.timeScale = 1;
		//get the animator component
		anim = pauseMenuPanel.GetComponent<Animator>();
		//disable it on start to stop it from playing the default animation
		anim.enabled = false;
	}
	
	// Update is called once per frame
	public void Update () {
		//pause the game on escape key press and when the game is not already paused
		if(Input.GetKeyDown(pauseButton) && !isPaused){
			PauseGame();
			PauseSound.Play();

		}
		//unpause the game if its paused and the escape key is pressed
		else if(Input.GetKeyDown(pauseButton) && isPaused){
			UnpauseGame();
			UnPauseSound.Play();
		}
	}
	
	//function to pause the game
	public void PauseGame(){
		//enable the animator component
		anim.enabled = true;
		//play the Slidein animation
		anim.Play("PauseMenuSlideIn");
		//set the isPaused flag to true to indicate that the game is paused
		isPaused = true;
		//freeze the timescale
		Time.timeScale = 0;
	}
	//function to unpause the game
	public void UnpauseGame(){
		//set the isPaused flag to false to indicate that the game is not paused
		isPaused = false;
		//play the SlideOut animation
		anim.Play("PauseMenuSlideOut");
		//set back the time scale to normal time scale
		Time.timeScale = 1;
	}
	
}

