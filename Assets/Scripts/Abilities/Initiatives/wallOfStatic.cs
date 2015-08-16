using UnityEngine;
using System.Collections;

public class wallOfStatic : Initiative
{
	
	public wallOfStatic()
	{
		name = "Wall of Static";
		description = "1) End the run";
		rezCost = 3;
		iceStr = 3;
		type = "Ice";
		type2 = "Barrier";
		kind = "Neutral";
	}
	
	public override void effect()
	{
		Debug.Log ("Static wall");

		Vector2 click = mouseClick ();
		Vector3 position = new Vector3(click.x, 0, click.y);
		GameObject fw = PhotonNetwork.Instantiate ("firewall", position, Quaternion.identity, 0);
		
		fw.AddComponent<Ice>();
		Ice ice = fw.GetComponent<Ice>();
		EndRun endRun = ice.gameObject.AddComponent<EndRun>() as EndRun;
		ice.build(name, rezCost, type, type2, iceStr);
	}
}