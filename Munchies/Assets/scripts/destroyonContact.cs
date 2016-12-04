<<<<<<< HEAD
﻿/*using UnityEngine;
using System.Collections;

public class destroyonContact : MonoBehaviour {
	int score = 0;
	//Text scoreText = GetComponent (UI.ScoreText);
=======
﻿using UnityEngine;
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
>>>>>>> dcde63f09c496e13c09988847c8c60dc8ffb7320

	void OnTriggerEnter2D (Collider2D other)
	{
		score++;
		Debug.Log (score);
		Destroy (other.gameObject);
	}
<<<<<<< HEAD
}
*/
=======

	void UpdateScore()
	{
		ScoreText.text = "Score: " + score;
	}
}
>>>>>>> dcde63f09c496e13c09988847c8c60dc8ffb7320
