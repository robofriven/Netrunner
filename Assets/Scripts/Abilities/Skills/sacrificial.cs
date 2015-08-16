using UnityEngine;
using System.Collections;

public class sacrificial : Skill {

	public sacrificial()
	{
		name = "Sacrificial Construct";
		description = "Trash: Prevent an installed program or an installed piece of hardware from being trashed";
		castTime = 10;
		corp = false;
		cost = 0;
		type = "resource";
		type2 = "remote";
		faction = "shaper";
		influence = 1;

	}
	
	public override void effect()
	{
		Debug.Log("Sacrificed");
		// When a program or hardware should be destroyed
		// Give option to destroy this instead
		// if yes
		// Destroy this
	}
}