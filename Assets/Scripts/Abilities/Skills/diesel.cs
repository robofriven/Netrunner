using UnityEngine;
using System.Collections;

public class diesel : Skill {

	public diesel()
	{
		name = "Diesel";
		description = "Draw 3 cards";
		castTime = 10;
		corp = false;
		cost = 0;
		type = "event";
		type2 = null;
		faction = "shaper";
		influence = 2;
	}
	
	public override void effect()
	{
		Debug.Log("Diesel: You need to figure out how to handle this.");
		Runner runner = findRunner ();
		RunnerController rc = findRC ();
		if (runner.credits >= cost)
		{
			runner.credits -= cost;
			for (int i = 0; i < 3; i++)
			{
				rc.draw(ref runner.deck);
			}
		}
		timer (1);
	}
}