using UnityEngine;
using System.Collections;

public class hedgeFund : Initiative
{
	
	public hedgeFund()
	{
		name = "Hedge Fund";
		cost = 5;
		description = "Gain 9cr";
		type = "Operation";
		type2 = "Transaction";
		kind = "Neutral";
	}
	
	public override void effect()
	{
		Debug.Log ("Hedge Fund");
		Corp corp = findCorp();
		if (corp.credits >= cost)
		{
			corp.credits += 4;
			timer(1);
		}
		else
		{
			// Tell the player that they can't afford it (popup?)
			Debug.Log("You can't afford that Initiative right now");
		}
	}
}