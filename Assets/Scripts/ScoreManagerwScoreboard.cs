using UnityEngine;
using System.Collections.Generic;
using System.Linq; //Check documentation on this
using UnityEngine.UI;

public class ScoreManagerwScoreboard : MonoBehaviour {

    //We need some sort of map that goes from a USERNAME to a SCORE
    //The map we are building is going to look like:
    //
    // LIST OF USERS -> A User -> LIST OF SCORES for that user
    //

    Dictionary<string, Dictionary<string, int> > playerScores;
    int changeCounter = 0;
    public Text scoreText;

    string playTime;

    void Start()
    {
        scoreText = GetComponent <Text>() as Text;
        playTime = PlayerPrefs.GetString("PlayerTime");

        SetScore("quill18", "time", 9000);
        SetScore("quill18", "trials", 15);

        SetScore("Joel2015", "time", 2000);
        SetScore("Joel2015", "trials", 9001);

        SetScore("AAAAAAA", "time", 0);
        SetScore("AAAAAAA", "trials", 0);

        SetScore("BBBBBBB", "time", 0);

        SetScore("CCCCCC", "time", 4321);
        SetScore("CCCCCC", "trials", 1234);



        Debug.Log(GetScore("quill18", "kills"));

        //PlayerPref

        PlayerPrefs.GetString("PlayerTime");
        playTime = PlayerPrefs.GetString("PlayerTime");
    }

    void Update()
    {
        PlayerPrefs.SetString("PlayerTime", CountdownTimer.countdownText.text);
        scoreText.text = "Completed with " + playTime + " Time Remaining";
        Debug.Log(PlayerPrefs.GetString("PlayerTime"));
    }


    void Init()
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
}
