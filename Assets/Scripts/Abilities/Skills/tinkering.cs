using UnityEngine;
using System.Collections;

public class tinkering : Skill {

	public tinkering() 
	{
		name = "Tinkering";
		description = "Choose a piece of ice. That ice gains Sentry, Code Gate, and Barrier utntil the end of turn";
		castTime = 10;
		corp = false;
		cost = 0;
		type = "event";
		type2 = "mod";
		faction = "shaper";
		influence = 4;
	}
	
	public override void effect()
	{
		Debug.Log("Tinkering Cast");
		// popup to click on ice and return ice

		//ice.type2 = "Sentry-Code Gate-Barrier"
	}
}