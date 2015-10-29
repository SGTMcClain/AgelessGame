using UnityEngine;
using System.Collections;

public class EndTileText : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        
        
       CountdownTimer.countdownText.text = CountdownTimer.minutes.ToString("00") + ":" + CountdownTimer.seconds.ToString("00");
    }
}
