using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class destroyonContact : MonoBehaviour {
	int score;
	public GUIText ScoreText;

	void Start()
	{
		score = 0;
		UpdateScore ();
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		score++;
		Debug.Log (score);
		Destroy (other.gameObject);
	}

	void UpdateScore()
	{
		ScoreText.text = "Score: " + score;
	}
}