using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndTileText : MonoBehaviour {

    public Text scoreText;
    private int playTimeMin = CountdownTimer.cTimerMin;
    private int playTimeSec = CountdownTimer.cTimerSec;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("playTime: " + CountdownTimer.countdownText.text);
        scoreText.text = "Completed with:\n" + CountdownTimer.countdownText.text + "\n" + "Remaining";  //Change default text in inspector to this line

        //CountdownTimer.countdownText.text = CountdownTimer.minutes.ToString("00") + ":" + CountdownTimer.seconds.ToString("00");
    }
}
