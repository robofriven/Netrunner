using UnityEngine;
using System.Collections;

public class rabbitHole : Skill {

	public rabbitHole() 
	{
		name = "Rabbit Hole";
		description = "+1 MEM When Rabbit hole is install, you may search your stack for another Rabbit Hole and install it by paying it's cost, shuffle the stack";
		castTime = 10;
		corp = false;
		cost = 2;
		type = "hardware";
		faction = "shaper";
		influence = 1;
	}

	// TODO Prompt for choosing another rabbit hole
	public override void effect()
	{
		Debug.Log("Rabbit Hole");
		Runner runner = findRunner ();
		RunnerController rc = findRC ();
		if (runner.credits >= cost)
		{
			runner.mem ++;
			runner.credits -= cost;
		}
		// Prompt for choice to get another
		bool choose = false;
		if (choose)
		{
			for (int i = 0; i < rc.deck.Count; i++)
			{
				if (rc.deck[i].name == "Rabbit Hole")
				{
					rc.deck[i].effect();
					return;
				}
			}
		}
		else
		{
			timer (1);
		}
		// Option given to look for another rabbit hole
		// if yes
		// Remove Rabbit Hole
		// install cost for second rabbit hole removed
		// shuffle stack
	}
}