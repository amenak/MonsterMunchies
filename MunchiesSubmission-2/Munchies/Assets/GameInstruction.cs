using UnityEngine;
using System.Collections;

public class GameInstruction : MonoBehaviour {

	private string camInst="";

	private bool show=false;

	// Use this for display your text on monitor
	void Start () {
		camInst="";
		camInst+="- w,a,s,d key 2 move your player on map ";
		camInst+="- right click and kill your self \n";
		camInst+="- mouse scrole wheel to die\n";
		camInst+="- touch monitor with your head 2 play game\n";

		camInst+="- w,a,s,d key 2 move your player on map ";
		camInst+="- right click and kill your self \n";
		camInst+="- mouse scrole wheel to die\n";
		camInst+="- touch monitor with your head 2 play game\n";

		camInst+="\n iff you read this text you rule dude \n";

		camInst+="\n put your text here and make use of info buton yoes you will ";


		camInst+="\n iff you read this text you rule dude \n";

		camInst+="\n put your text here and make use of info buton yoes you will ";
		//camInst+="\n- mouse will kill your table on night\n";
	}

	// Update is called once per frame
	void Update () {

	}

	void OnGUI(){

		if(GUI.Button(new Rect(Screen.width- 45, 10, 35, 35), "Instructions")){
			show=!show;
		}

		if(show) GUI.Label(new Rect(Screen.width-310, 50, 300, 500), camInst);
	}
}