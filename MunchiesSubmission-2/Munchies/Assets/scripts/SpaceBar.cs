using UnityEngine;
using System.Collections;

public class SpaceBar : MonoBehaviour {

public int num;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    if (Input.GetKeyDown("space"))
        print("space key was pressed");

	}
}
