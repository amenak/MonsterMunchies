using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {
	

	public Camera cam;
	public GameObject food; 
	public GameObject Heading, newObject;
	//public GameObject food2; 
	private float maxWidth;
	private UnityEngine.UI.Text question, foodText;
	private string[,] solutions = new string[5,2] {{"What is a word to describe somebody who is talented beyond their age?","precocious"},{"What is a word to describe a leader gaining support by speaking to peoples interests?","demagogue"},{"What is a word to describe something out-of-date?", "anachronistic"},{"What is a word for the opposite of loyal?","perfidious"},{"What is another word for impulsive?","impetuous"}};

	// Use this for initialization
	void Start () {
		Debug.Log("Hello");
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
		for (int i = 0; i < 5; i++) {
			question = Heading.GetComponent<UnityEngine.UI.Text>();
			question.text = solutions [i, 0];
			yield return new WaitForSeconds (2.0f); 
			Vector3 spawnPosition = new Vector3 (
				                        Random.Range (-maxWidth, maxWidth),
				                        transform.position.y,
				                        -1.0f);
			Quaternion spawnRotation = Quaternion.identity;
			GameObject newObject = (GameObject)Instantiate (food, spawnPosition, spawnRotation);
			TextMesh hello = newObject.transform.GetComponent<TextMesh> ();
			hello.text = solutions [i, 1];
			//Instantiate (food2, spawnPosition, spawnRotation); 
			yield return new WaitForSeconds (Random.Range (1.0f, 2.0f));
		}
	}	


}