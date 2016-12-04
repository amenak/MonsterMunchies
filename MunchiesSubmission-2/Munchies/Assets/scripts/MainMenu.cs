using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	public bool isStart;
	public bool isInstruct;
	public bool isHigh;

	// Use this for initialization
	void Start () {
		print ("starting");
	
	}
	
	void OnMouseUp(){
		if(isStart)
		{
			//Application.LoadLevel(1);
		}
		if (isInstruct)
		{
			
		}
		if (isHigh) 
		{
			
		}	
	} 

	public void clickStart()
	{
		print ("button pressed");
		Application.LoadLevel(1);
	}

	public void clickQuit()
	{
		Application.Quit ();
	}

	public void clickHighScores()
	{
		print ("HighScores");
	}

	public void clickInstructions()
	{
		print ("Instructions");
		Application.LoadLevel (2);
	}




}
