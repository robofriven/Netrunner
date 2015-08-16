using UnityEngine;
using System.Collections;

public class infiltration : Skill
{
	
	public infiltration()
	{
		name = "Infiltration";
		description = "Gain 2cr: or expose 1 'card'";
		castTime = 10;
		corp = false;
		cost = 0;
		type = "event";
		faction = "neutral";
	}
	
	public override void effect()
	{
		Debug.Log("Infiltrated");
		//Make Choice
			// gain 2cr or
			// expose
	}
}
