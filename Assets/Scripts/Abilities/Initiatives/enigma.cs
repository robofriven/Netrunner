using UnityEngine;
using System.Collections;
using System.Collections.Generic;

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


		Debug.Log ("Archer");
		EventHandler.waitForClick();
		EventHandler.CLICKRECEIVED += fwInstantiate;
	}
	public void fwInstantiate(Vector2 position)
	{
		
		if (position == new Vector2(-2,-2) || position == new Vector2(-1,-1))
		{
			Debug.LogWarning ("Put it in a logical place! ... Popup and all that.");
			EventHandler.waitForClick();
		}
		else
		{
			Vector3 click = new Vector3(position.x, 2.5f, position.y);
			
			GameObject fw = PhotonNetwork.Instantiate ("firewall", click, Quaternion.identity, 0);
			
			fw.AddComponent<Ice>();
			Ice ice = fw.GetComponent<Ice>();
			TimeLoss timeLoss = ice.gameObject.AddComponent<TimeLoss>() as TimeLoss;
			EndRun endRun = ice.gameObject.AddComponent<EndRun>() as EndRun;
			ice.build(name, rezCost, type, type2, iceStr);
			
			ice.subroutines.Add(timeLoss);
			ice.subroutines.Add(endRun);
		}
	}
}