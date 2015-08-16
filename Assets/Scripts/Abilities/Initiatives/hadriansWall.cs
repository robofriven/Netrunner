using UnityEngine;
using System.Collections;

public class hadriansWall : Initiative{

	public hadriansWall()
	{
		name = "Hadrian's Wall";
		description = "Hadrian's Wall can be advanced and has +1 str for each token on it. 1) End the run 2) End the run";
		rezCost = 10;
		iceStr = 7;
		type = "ice";
		type2 = "barrier";
		kind = "Weyland";
		influence = 3;
		advancement = 0;
	}

	public override void effect()
	{
		//iceStr = 7 + adcancement;
		// End the run
		// End the run
		Debug.Log("Hadrian's Wall");
	}
}
