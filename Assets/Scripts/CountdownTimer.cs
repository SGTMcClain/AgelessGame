using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour {

    public Text countdownText;
    private Animator anim;
    public GameObject pauseMenuPanel;

    static float seconds, minutes;
    //
    //This variable adujst the amount of time allowed for the level.
    //Since seconds are added at runtime minutes will appear as one minute less than
    //minutes inserted i.e. 5 minute timer will display 4:59 at runtime
    public float lengthOfTimeInMinutes = 5f;
    

    //public float totalTime = 60f;
    // Use this for initialization
    void Start()
    {
        countdownText = GetComponent<Text>() as Text;
        anim = pauseMenuPanel.GetComponent<Animator>();
        anim.enabled = false;
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
        if (minutes == 0 && seconds <= 1)
        {
            seconds = 0;
            PauseGame();
            //anim.enabled = true;
        }

        countdownText.text = minutes.ToString("00") + ":" + seconds.ToString("00");

        
    }

    public static void PauseGame()
    {

        Time.timeScale = 0;
        
        
    }

    public static void ResumeGame()
    {
        Time.timeScale = 1;
    }
}
