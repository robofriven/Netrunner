using UnityEngine;
using System.Collections;

public class netShield : Skill {

	public netShield()
	{
		name = "Net Shield";
		description = "1cr: prevent the first net damage this turn.";
		castTime = 10;
		corp = false;
		cost = 2;
		type = "program";
		type2 = null;
		memCost = 1;
		faction = "shaper";
		influence = 1;
	}
	
	public override void effect()
	{
		Debug.Log("net Shield");
		// Set up a listener for the first net damage someone takes a turn
		// Give option to pay 1cr
		// if yes, net damage -= 1
	}
}