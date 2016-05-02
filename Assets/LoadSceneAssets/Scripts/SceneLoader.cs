using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour {

	public float timeTillLevelLoad;
	public int nextLevelNumber;
	public Image LoadingBar;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//As soon as this loading scene starts countdown until enough time has passed to load the next scene in line
		if (Time.timeSinceLevelLoad >= timeTillLevelLoad)
		{
			NextLevel ();
		}

		LoadingBar.fillAmount = Time.timeSinceLevelLoad / timeTillLevelLoad;
	}

	//Get the current scene and increment by one
	public void NextLevel (){

		//Debug.Log (SceneManager.GetActiveScene ());

		SceneManager.LoadScene (nextLevelNumber);
	}
}
