using UnityEngine;
using System.Collections;

public class researchStation : Initiative
{	
	public researchStation()
	{
		name = "Research Station";
		cost = 2;
		description = "Install only in the root of HQ. Your max HAND SIZE is +2";
		type = "Upgrade";
		type2 = "Facility";
		kind = "Weyland";
		influence = 1;
		trashCost = 3;
	}
	
	public override void effect()
	{
		//TODO Upgrade for only HQ
		// Has HQ been upgraded?
			// yes, popup error and return
			// no, place at HQ

		Debug.Log ("Research Station");
		Corp corp = findCorp();
		corp.handSize += 2;

	}
}