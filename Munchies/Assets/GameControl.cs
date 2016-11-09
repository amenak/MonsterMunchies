using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {

	public Camera cam;
	public GameObject food; 
	//public GameObject food2; 
	private float maxWidth;


	// Use this for initialization
	void Start () {

		if (cam == null)
		{
			cam = Camera.main;
		}
		Vector3 upperCorner = new Vector3 (Screen.width, Screen.height, 0.0f);
		Vector3 targetWidth = cam.ScreenToWorldPoint (upperCorner);
		maxWidth = targetWidth.x; 
		StartCoroutine (Spawn ()); 
	}

	IEnumerator Spawn (){
		//Need x,y,z
		while (true) {
			yield return new WaitForSeconds (2.0f); 
			Vector3 spawnPosition = new Vector3 (
				                        Random.Range (-maxWidth, maxWidth),
				                        transform.position.y,
				                        -1.0f);
			Quaternion spawnRotation = Quaternion.identity; 
			Instantiate (food, spawnPosition, spawnRotation);
			//Instantiate (food2, spawnPosition, spawnRotation); 
			yield return new WaitForSeconds (Random.Range (1.0f, 2.0f));
		}
	}	


}
