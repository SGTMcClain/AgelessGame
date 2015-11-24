using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour {

    public static Text countdownText;
    public static float seconds, minutes;
    //
    //This variable adujst the amount of time allowed for the level.
    //Since seconds are added at runtime minutes will appear as one minute less than
    //minutes inserted i.e. 5 minute timer will display 4:59 at runtime
    public float lengthOfTimeInMinutes = 5f;
    private Animator anim;
    public GameObject pauseMenuPanel;

    //private bool isPaused = false;


    //public float totalTime = 60f;
    // Use this for initialization
    void Start()
    {
        countdownText = GetComponent<Text>() as Text;
        anim = pauseMenuPanel.GetComponent<Animator>();
        anim.enabled = false;
        //Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //To get the clock to display as a normal clock we divide timeSinceLevelLoad by 60 and the remainder by 60
        //The negative sign in front of time is there to make sure the clock is running backwards
        //lengthOfTime is the variable defined above that is adjustable for the level
        //Adding 60f to secondsRemaining prevents the seconds from displaying a negative number
        minutes = (int)(Mathf.Clamp(((-Time.timeSinceLevelLoad / 60f) + lengthOfTimeInMinutes), 0f, lengthOfTimeInMinutes)); //Mathf.Clamp() keeps the clock from displaying negative numbers
        seconds = (int)((-Time.timeSinceLevelLoad % 60f) + 60f);

        //make the clock stop at 00:00
        if (minutes == 0f && seconds <= 1f)
        {
            seconds = 0;
            PauseGame();
            
        }

        countdownText.text = minutes.ToString("00") + ":" + seconds.ToString("00");

        
        
    }

    public void PauseGame()
    {
        //enable the animator component
        anim.enabled = true;
        //play the Slidein animation
        anim.Play("FailPauseMenuSlideIn");
        //set the isPaused flag to true to indicate that the game is paused
        //isPaused = true;
        //freeze the timescale
        Time.timeScale = 0;
    }


    public void ResumeGame()
    {
        Time.timeScale = 1;
    }
}
