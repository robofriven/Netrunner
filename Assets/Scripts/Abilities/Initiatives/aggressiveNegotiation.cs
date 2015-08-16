using UnityEngine;
using System.Collections;

public class aggressiveNegotiation : Initiative
{
	
	public aggressiveNegotiation()
	{
		name = "Aggressive Negotiation";
		cost = 1;
		description = "Play only if you scoored an agenda IN FORTY SEC. Search the R&D for 1 cared and add it to HQ, shuffle R&D";
		type = "Operation";
		type2 = null;
		kind = "Weyland";
		influence = 1;
	}
	
	public override void effect()
	{
		Debug.Log ("Aggressive Negotiating");
		// Did corp score agenda in time alloted?
			//yes
				// Let them pick a card from the deck
			// no
				// cancel effect
	}
}