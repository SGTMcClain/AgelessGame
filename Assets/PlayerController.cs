using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	public float walkSpeed = 1; // player left right walk speed
	private bool _isGrounded = true; // is player on the ground?
	
	Animator animator;
	
	//some flags to check when certain animations are playing
	bool _isPlaying_run = false;
	bool _isPlaying_jump = false;
	bool _isPlaying_punch = false;
	
	//animation states - the values in the animator conditions
	const int STATE_IDLE = 0;
	const int STATE_RUN = 1;
	const int STATE_JUMP = 2;
	const int STATE_PUNCH = 3;
	
	string _currentDirection = "left";
	int _currentAnimationState = STATE_IDLE;
	
	// Use this for initialization
	void Start()
	{
		//define the animator attached to the player
		animator = this.GetComponent<Animator>();
	}
	
	// FixedUpdate is used insead of Update to better handle the physics based jump
	void FixedUpdate()
	{
		//Check for keyboard input
		if (Input.GetKeyDown (KeyCode.Space))
		{
			changeState (STATE_JUMP);
		}
	/*	else if (Input.GetKey ("up") && !_isPlaying_hadooken && !_isPlaying_crouch)
		{
			if(_isGrounded)
			{
				_isGrounded = false;
				//simple jump code using unity physics
				rigidbody2D.AddForce(new Vector2(0, 250));
				changeState(STATE_JUMP);
			}
		}

		else if (Input.GetKey ("down"))
		{
			changeState(STATE_CROUCH);
		}


		else if (Input.GetKey ("right") && !_isPlaying_hadooken )
		{
			changeDirection ("right");
			transform.Translate(Vector3.left * walkSpeed * Time.deltaTime);
			
			if(_isGrounded)
				changeState(STATE_WALK);
			
		}
		else if (Input.GetKey ("left") && !_isPlaying_hadooken)
		{
			changeDirection ("left");
			transform.Translate(Vector3.left * walkSpeed * Time.deltaTime);
			
			if(_isGrounded)
				changeState(STATE_WALK);
			
		}
		else
		{
			if(_isGrounded)
				changeState(STATE_IDLE);
		}
		
		//check if crouch animation is playing

*/
if (animator.GetCurrentAnimatorStateInfo(0).IsName("punch"))
			_isPlaying_punch = true;
		else
			_isPlaying_punch= false;

		//check if hadooken animation is playing
		if (animator.GetCurrentAnimatorStateInfo(0).IsName("run"))
			_isPlaying_run = true;
		else
			_isPlaying_run = false;
		
		//check if strafe animation is playing
		if (animator.GetCurrentAnimatorStateInfo(0).IsName("jump"))
			_isPlaying_jump = true;
		else
			_isPlaying_jump = false;
		
	}
	
	//--------------------------------------
	// Change the players animation state
	//--------------------------------------
	void changeState(int state){
		
		if (_currentAnimationState == state)
			return;
		
		switch (state) {
			
		case STATE_RUN:
			animator.SetInteger ("state", STATE_RUN);
			break;
			
		case STATE_PUNCH:
			animator.SetInteger ("state", STATE_PUNCH);
			break;
			
		case STATE_JUMP:
			animator.SetInteger ("state", STATE_JUMP);
			break;
			
		case STATE_IDLE:
			animator.SetInteger ("state", STATE_IDLE);
			break;
		}
		
		_currentAnimationState = state;
	}
	
	//--------------------------------------
	// Check if player has collided with the floor
	//--------------------------------------
	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.name == "Floor")
		{
			_isGrounded = true;
			changeState(STATE_IDLE);
			
		}
		
	}
	
	//--------------------------------------
	// Flip player sprite for left/right walking
	//--------------------------------------
	void changeDirection(string direction)
	{
		
		if (_currentDirection != direction)
		{
			if (direction == "right")
			{
				transform.Rotate (0, 180, 0);
				_currentDirection = "right";
			}
			else if (direction == "left")
			{
				transform.Rotate (0, -180, 0);
				_currentDirection = "left";
			}
		}
		
	}
	
}