using UnityEngine;
using System.Collections;

public class shipment : Initiative
{
	
	public shipment()
	{
		name = "Shipment from Kaguya";
		cost = 0;
		description = "Place 1 adv token on each of up to 2 different installed cards tht can be advanced.";
		type = "Operation";
		type2 = null;
		kind = "Weyland";
		influence = 1;
	}
	
	public override void effect()
	{
		Debug.Log ("Shipment from Kaguya");
		// tokens = 2
		// Click on card
			// card been clicked?
				// no
					// tokens -=1
					// card.advancement ++
				// yes
					// click different card
	}
}