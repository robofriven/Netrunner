using UnityEngine;
using System.Collections;

public class batteringRam : Skill {
	
	public batteringRam() 
	{
		name = "Battering Ram";
		description = "1cr: +1 str for remainder of run. 2cr: Break up to 2 barrier subroutines";
		castTime = 10;
		corp = false;
		cost = 5;
		type = "program";
		type2 = "icebreaker";
		str = 3;
		memCost = 2;
		faction = "shaper";
		influence = 2;
	}

	public override void effect()
	{
		Debug.Log("Ram has been battered");
		//Prompt user for What they're paying.
		//if pay is 2
		// Break up to 2 barrier sub routines
		//if pay is 1
		// +1 str for remainder of run
	}
}
