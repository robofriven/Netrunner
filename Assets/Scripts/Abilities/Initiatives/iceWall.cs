using UnityEngine;
using System.Collections;

public class iceWall : Initiative
{
	
	public iceWall()
	{
		name = "Ice Wall";
		description = "Ice Wall can be advanced, and has +1 str for each token on it 1) End run";
		rezCost = 1;
		iceStr = 1;
		type = "ice";
		type2 = "barrier";
		kind = "Weyland";
		influence = 1;
	}
	
	public override void effect()
	{
		// iceStr = 1 + advancement
		//end the run
		Debug.Log ("A wall of ice!");

		Vector2 click = mouseClick ();
		Vector3 position = new Vector3(click.x, 0, click.y);
		GameObject fw = PhotonNetwork.Instantiate ("firewall", position, Quaternion.identity, 0);
		
		fw.AddComponent<Ice>();
		Ice ice = fw.GetComponent<Ice>();
		Advancement advancement = ice.gameObject.AddComponent<Advancement>() as Advancement;
		EndRun endRun = ice.gameObject.AddComponent<EndRun>() as EndRun;
		ice.build(name, rezCost, type, type2, iceStr);
	}
}
