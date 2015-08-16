using UnityEngine;
using System.Collections;

public class akamatsuMemChip : Skill {

	public akamatsuMemChip() 
	{
		name = "Akamatsu Mem Chip";
		description = "+1 MEM";
		castTime = 10;
		corp = false;
		cost = 1;
		type = "hardware";
		type2 = "chip";
		faction = "shaper";
		influence = 1;
	}
	
	public override void effect()
	{
		Debug.Log("Akamatsu Mem chip installed");
		timer (1);
		Runner runner = findRunner ();
		if (runner.credits >= cost)
		{
			runner.mem ++;
			runner.credits -= cost;
		}
	}
}