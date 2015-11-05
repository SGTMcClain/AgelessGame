using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerScoreList : MonoBehaviour {

    public GameObject playerScoreEntryPrefab;

    ScoreManager scoreManager;

    int lastChangeCounter;
     
    // Use this for initialization
	void Start () {

        scoreManager = GameObject.FindObjectOfType<ScoreManager>();

        lastChangeCounter = scoreManager.GetChangeCounter();
       
	
	}
	
	// Update is called once per frame
	void Update () {

        if (scoreManager == null)
        {
            Debug.LogError("You  forgot to add the score manager component to a game object!");
            return;
        }

        if(scoreManager.GetChangeCounter() == lastChangeCounter)
        {
            //No change since last update!
            return;
        }

        lastChangeCounter = scoreManager.GetChangeCounter();

        while (this.transform.childCount > 0)
        {
            Transform c = this.transform.GetChild(0);
            c.SetParent(null); //Became Batman
            Destroy(c.gameObject);
        }

        string[] names = scoreManager.GetPlayerNames("time"); //parenthesis can be empty or have the string name of the property you want to sort

        foreach (string name in names)
        {
            GameObject go = (GameObject)Instantiate(playerScoreEntryPrefab);
            go.transform.SetParent(this.transform);
            go.transform.Find("Username").GetComponent<Text>().text = name;
            go.transform.Find("Time").GetComponent<Text>().text = scoreManager.GetScore(name, "time").ToString();
            go.transform.Find("Trials").GetComponent<Text>().text = scoreManager.GetScore(name, "trials").ToString();
        }
    }
}
