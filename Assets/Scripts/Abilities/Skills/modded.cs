using UnityEngine;
using System.Collections;

public class modded : Skill {

	public modded()
	{
		name = "Modded";
		description = "Install a program or a piece of hardware lowering the install cost by 3";
		castTime = 0;
		corp = false;
		cost = 0;
		type = "event";
		type2 = "mod";
		faction = "shaper";
		influence = 2;
	}
	
	public override void effect()
	{
		Debug.Log("Modded has been called");
		// Prompt to choose another skill
		// If skill clicked is type "program || hardware"
			// click.cost -= 3;
			// click.effect()
			// prompt to select correct type
	}
}
