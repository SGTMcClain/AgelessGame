//Author: Nathan McClain
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountdownTimerWorking : MonoBehaviour {

	public Text countdownText;
	float seconds, minutes;
	//This variable adujst the amount of time allowed for the level.
	public float lengthOfTime;

	//public float totalTime = 60f;
	// Use this for initialization
	void Start () {
		countdownText = GetComponent<Text>() as Text;
		}
	
	// Update is called once per frame
	void Update () {
		//To get the clock to display as a normal clock we divide timeSinceLevelLoad by 60 and the remainder by 60
		//The negative sign in front of time is there to make sure the clock is running backwards
		//lengthOfTime is the variable defined above that is adjustable for the level
		//Adding 60f to secondsRemaining prevents the seconds from displaying a negative number
		minutes = (int)((-Time.timeSinceLevelLoad / 60f) + lengthOfTime);
		seconds = (int)((-Time.timeSinceLevelLoad % 60f) + 60f);
		countdownText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
	
	}
}
