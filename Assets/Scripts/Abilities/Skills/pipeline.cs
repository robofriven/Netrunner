using UnityEngine;
using System.Collections;

public class pipeline : Skill {

	public pipeline() 
	{
		name = "Pipeline";
		description = "1cr: Break sentry subroutine. 2cr: +1 str for the remainder of this run.";
		castTime = 10;
		corp = false;
		cost = 3;
		type = "program";
		type2 = "icebreaker";
		str = 1;
		memCost = 1;
		faction = "shaper";
		influence = 1;
	}
	
	public override void effect(int pay)
	{
		Debug.Log("Pipeline");
		// if pay = 1
		// break sentry subroutine
		// if pay = 2
		// +1 str for rest of run
	}
}