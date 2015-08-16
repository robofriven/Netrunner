using UnityEngine;
using System.Collections;

public class melangeMining : Initiative
{
	
	public melangeMining()
	{
		name = "Melange Mining Corp.";
		description = "three clicks: Gain 7cr";
		rezCost = 1;
		type = "Asset";
		type2 = null;
		kind = "Neutral";
		trashCost = 1;
	}
	
	public override void effect()
	{
		Debug.Log ("Mining corp ho!");
		if (rezzed)
		{
			timer(3);
			Corp corp = findCorp();
			corp.credits += 7;
		}
		else
		{
			rezInit();
		}
	}
}