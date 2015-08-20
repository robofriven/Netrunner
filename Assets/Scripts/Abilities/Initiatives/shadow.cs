using UnityEngine;
using System.Collections;

public class shadow : Initiative
{
	
	public shadow()
	{
		name = "Shadow";
		description = "1)Shadow can be advanced and has +1 str for each token on it. 2) The Corp gains 2cr 3)Trace(3) If succesful, give the runner 1 tag";
		rezCost = 3;
		iceStr = 1;
		type = "ice";
		type2 = "sentry-tracer";
		kind = "Weyland";
		influence = 1;
	}
	
	public override void effect()
	{
		Debug.Log ("THE SHADOW!!!");
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
			
			GameObject fw = PhotonNetwork.Instantiate ("Shadow", click, Quaternion.identity, 0);
		}
	}
}
