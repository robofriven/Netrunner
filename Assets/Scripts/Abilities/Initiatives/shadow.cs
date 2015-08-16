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

		Vector2 click = mouseClick ();
		Vector3 position = new Vector3(click.x, 0, click.y);
		GameObject fw = PhotonNetwork.Instantiate ("firewall", position, Quaternion.identity, 0);
		
		fw.AddComponent<Ice>();
		Ice ice = fw.GetComponent<Ice>();
		Advancement advancement = ice.gameObject.AddComponent<Advancement>() as Advancement;
		Payment pay = ice.gameObject.AddComponent<Payment>() as Payment;
		Trace trace = ice.gameObject.AddComponent<Trace>() as Trace;
		trace.str = 3;
		ice.build(name, rezCost, type, type2, iceStr);
	}
}
