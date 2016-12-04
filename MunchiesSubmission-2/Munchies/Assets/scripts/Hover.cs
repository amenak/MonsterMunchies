using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Hover : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//GetComponent<Renderer>().material.color = Color.black;
		
	}

	void OnMouseEnter()
	{	
		//GetComponent<Renderer>().material.color = Color.white;
	}

	void OnMouseExit()
	{
		//GetComponent<Renderer>().material.color = Color.black;
	}


}
