using UnityEngine;
using System.Collections;

public class magnumOpus : Skill {

	public magnumOpus() 
	{
		name = "Magnum Opus";
		description = "Spend 10s to gain 2cr:";
		castTime = 10;
		corp = false;
		cost = 5;
		type = "program";
		type2 = null;
		memCost = 2;
		faction = "shaper";
		influence = 2;
	}
	
	public override void effect()
	{
		Debug.Log("The Personal Touch");
		Runner runner = findRunner ();
		if (runner.credits >= cost)
		{
			runner.credits += 2;

		}
		timer (1);
	}
}