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
			Advancement advance = ice.gameObject.AddComponent<Advancement>() as Advancement;

			EndRun endRun = ice.gameObject.AddComponent<EndRun>() as EndRun;
			ice.build(name, rezCost, type, type2, iceStr);

			ice.subroutines.Add(endRun);
		}
	}
}
