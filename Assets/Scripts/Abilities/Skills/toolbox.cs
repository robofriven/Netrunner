using UnityEngine;
using System.Collections;

public class toolbox : Skill {

	public toolbox() 
	{
		name = "The Toolbox";
		description = "CONSOLE: +2 MEM, +2 LINKS, 2cr, use these credits for using icebreakers";
		castTime = 10;
		corp = false;
		cost = 9;
		type = "hardware";
		type2 = "console";
		faction = "shaper";
		influence = 2;
	}
	
	public override void effect()
	{
		Debug.Log("You can only have one console per player.");
		Runner runner = findRunner ();
		if (runner.credits >= cost)
		{
			runner.mem += 2;
			runner.links += 2;

			// TODO Insert a listener for runner.run being true
				// credits += 2;

			runner.credits -= cost;
			timer (1);
		}
	}
}