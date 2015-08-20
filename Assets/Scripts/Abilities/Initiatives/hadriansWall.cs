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
			EndRun endRun2 = ice.gameObject.AddComponent<EndRun>() as EndRun;
			
			ice.build(name, rezCost, type, type2, iceStr);

			ice.subroutines.Add(endRun);
			ice.subroutines.Add(endRun2);
		}
	}
}
