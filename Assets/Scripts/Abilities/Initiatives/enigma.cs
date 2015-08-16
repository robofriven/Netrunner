using UnityEngine;
using System.Collections;

public class enigma : Initiative
{
	
	public enigma()
	{
		name = "Enigma";
		description = "1) Runner loses 10s 2) End the run";
		rezCost = 3;
		iceStr = 2;
		type = "Ice";
		type2 = "Code Gate";
		kind = "Neutral";
	}
	
	public override void effect()
	{
		Debug.Log ("Building Enigma");

		Vector2 click = mouseClick ();
		Vector3 position = new Vector3(click.x, 0, click.y);
		GameObject fw = PhotonNetwork.Instantiate ("firewall", position, Quaternion.identity, 0);
		fw.AddComponent<Ice>();
		Ice ice = fw.GetComponent<Ice>();
		TimeLoss timeLoss = ice.gameObject.AddComponent<TimeLoss>() as TimeLoss;
		EndRun endRun = ice.gameObject.AddComponent<EndRun>() as EndRun;
		ice.build(name, rezCost, type, type2, iceStr);
	}
}