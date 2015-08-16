using UnityEngine;
using System.Collections;

public class Weyland : Corp
{
	public Weyland()
	{
		name = "Weyland Consortium";
		description = "Gain 1cr whenever you play a transaction operation";
		identity = "Megacorp";
	}

	public override void effect()
	{
		Debug.Log("Weyland ability called");
		// When operation played
			// look for transaction in type2
				// credits ++;
	}
}
