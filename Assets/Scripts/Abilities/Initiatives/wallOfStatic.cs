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
			
			GameObject fw = PhotonNetwork.Instantiate ("Wall of Static", click, Quaternion.identity, 0);
		}
	}
}