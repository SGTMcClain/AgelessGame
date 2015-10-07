using UnityEngine;
using System.Collections;

public class PlatformMove : MonoBehaviour {
	public Vector3 pointB;
	
	IEnumerator Start()
	{
		var pointA = transform.position;
		while (true) {
			yield return StartCoroutine(MoveObject(transform, pointA, pointB, 3.0f));
			yield return new WaitForSeconds(3); // when platform reaches point B it waits to go back to Point A
			yield return StartCoroutine(MoveObject(transform, pointB, pointA, 3.0f));

		}
	}
	
	IEnumerator MoveObject(Transform thisTransform, Vector3 startPos, Vector3 endPos, float time)
	{
		var i= 0.0f;
		var rate= 1.0f/time; //how fast the object moves
		while (i < 1.0f) {
			i += Time.deltaTime * rate;
			thisTransform.position = Vector3.Lerp(startPos, endPos, i);
			yield return null; 
		}

	}

}