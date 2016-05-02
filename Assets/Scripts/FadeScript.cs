using UnityEngine;
using System.Collections;

public class FadeScript : MonoBehaviour {

	public Texture2D fadeOutTexture; //the variable that will hold the black box texture
	public float fadeSpeed = 0.5f; //the speed at which the alpha will change

	private int drawDepth = -1000; //gui depth
	private float alpha = 1.0f; //alpha float variable
	private int fadeDir = -1; //the direction fading will happen (1 = Fade To Black, -1 = Fade From Black)

	void OnGUI () {
		//Alpha is plus-equal to fadeDir(1,-1) times fadeSpeed times Time.deltaTime
		alpha += fadeDir * fadeSpeed * Time.deltaTime;
		//Since alphas only work with 0-1, we can clamp the variable
		alpha = Mathf.Clamp01 (alpha);

		//The text color is equal to what it normally is with the new alpha variable
		GUI.color = new Color (GUI.color.r, GUI.color.g, GUI.color.b, alpha);
		//The depth is set to the default (-1000)
		GUI.depth = drawDepth;
		//We're rendering the texture on a rectangle that will cover the entire screen regardless on ratio
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), fadeOutTexture);
	}

	//when BeginFade(1) gets called, Fade to black; if BeginFade(-1) gets called, Fade from black
	public float BeginFade (int direction)
	{
		fadeDir = direction;
		return (fadeSpeed);
	}

	//Fade from black when the scene starts
	void Start()
	{
		BeginFade (-1);
	}
		
}
