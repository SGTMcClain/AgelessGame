﻿using UnityEngine;
using System.Collections.Generic;
using System.Linq; //Check documentation on this
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    //We need some sort of map that goes from a USERNAME to a SCORE
    //The map we are building is going to look like:
    //
    // LIST OF USERS -> A User -> LIST OF SCORES for that user
    //

    Dictionary<string, Dictionary<string, int> > playerScores;
    int changeCounter = 0;
    public Text scoreText;

    string playTime; //holds the time after it has been converted to a string

    void Start()
    {
        scoreText = GetComponent <Text>() as Text;
              
        //PlayerPref
        playTime = PlayerPrefs.GetString("PlayerTime");
    }

    void Update()
    {
        PlayerPrefs.SetString("PlayerTime", CountdownTimer.countdownText.text);  //Every update, update the PlayerPref "PlayerTime" with the current time
        scoreText.text = "Completed with " + playTime + " Time Remaining";  //Change default text in inspector to this line
        Debug.Log(PlayerPrefs.GetString("PlayerTime"));
    }

    // Code below contains elements for creating a scoreboard
    // This needs to be adjusted to match the above code
    // Ultimately this should allow for the current playerpref to be used as a variable
    // when initializing the scoreboard and then compare that score with other scores
    // a problem that may arize is the fact that time had to be converted to a string so we 
    // may need to pass the raw numerical data to the scoreboard with the
    // string data so that the code sees the score represented numerically while the
    // player sees the playTime string which would make more sense to a human
    // This way we should still be able to sort the data behind the scenes.
    /*void Init()
    {
        if (playerScores != null)
            return;

        playerScores = new Dictionary<string, Dictionary<string, int>>();
    }

    public int GetScore(string username, string scoreType)
    {
        Init();

        if(playerScores.ContainsKey(username) == false)
        {
            //we have no score record for this username
            return 0;
        }

        if (playerScores[username].ContainsKey(scoreType) == false)
        {
            return 0;
        }

        return playerScores[username][scoreType];
    }

    public void SetScore(string username, string scoreType, int value)
    {
        Init();

        changeCounter++;

        if(playerScores.ContainsKey(username) == false)
        {
            playerScores[username] = new Dictionary<string, int>();
        }

        playerScores[username][scoreType] = value;
    }
    
    public void ChangeScore(string username, string scoreType, int amount)
    {
        Init();

        int currScore = GetScore(username, scoreType);
        SetScore(username, scoreType, currScore + amount);
    }
	
    public string[] GetPlayerNames()
    {
        Init();
        return playerScores.Keys.ToArray();
    }

    public string[] GetPlayerNames(string sortingScoreType)
    {
        Init();

        //use playerScores.Keys.OrderByDescending if you want to sort from highest to lowest
        return playerScores.Keys.OrderBy( n => GetScore(n, sortingScoreType) ).ToArray();
    }

    public void DEBUG_ADD_KILL_TO_QUILL()
    {
        ChangeScore("quill18", "time", 1234);
    }

    public int GetChangeCounter()
    {
        return changeCounter;
    }
    */
}
