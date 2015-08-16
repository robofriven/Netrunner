using UnityEngine;
using System.Collections;

public class sureGamble : Skill
{
	
	public sureGamble()
	{
		name = "Sure Gamble";
		description = "Gain 9cr";
		castTime = 10;
		corp = false;
		cost = 5;
		type = "event";
		type2 = null;
		faction = "neutral";
	}
	
	public override void effect()
	{
		Debug.Log("It's good to be the king");
		Runner runner = findRunner ();
		if (runner.credits >= cost)
		{
			runner.credits += 4;
			timer (1);
		}
	}
}
