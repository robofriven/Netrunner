using UnityEngine;
using System.Collections;

public class hunter : Initiative
{
	
	public hunter()
	{
		name = "Hunter";
		description = "1) Trace(3) - if Successful give the runner 1 tag";
		rezCost = 1;
		iceStr = 4;
		type = "Ice";
		type2 = "Security-Tracer-Observer";
		kind = "Neutral";
	}
	
	public override void effect()
	{
		Debug.Log ("Hunter Ice");

		EventHandler.waitForClick();
		EventHandler.CLICKRECEIVED += fwInstantiate;

	}


	public void fwInstantiate(Vector2 position)
	{
		if (position == new Vector2(-2,-2) || position == new Vector2(-1,-1))
		{
			Debug.LogWarning ("Put it in a logical place!");
			EventHandler.waitForClick();
		}
		else
		{
			Vector3 click = new Vector3(position.x, 2.5f, position.y);
			
			GameObject fw = PhotonNetwork.Instantiate ("firewall", click, Quaternion.identity, 0);
			
			fw.AddComponent<Ice>();
			Ice ice = fw.GetComponent<Ice>();
			Trace trace = ice.gameObject.AddComponent<Trace>() as Trace;
			trace.str = 3;
			ice.build(name, rezCost, type, type2, iceStr);
		}
	}
}