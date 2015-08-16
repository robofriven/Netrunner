using UnityEngine;
using System.Collections;

public class armitage :  Skill
{
	bool inPlay;
	
	public armitage() 
	{
		name = "Armitage Codebusting";
		description = "Place 12cr. from the bank when it is installed.  when there are no more credits on armitage codebusting, trash it.  10s, take 2cr from Armitage Codebusting.";
		castTime = 10;
		corp = false;
		cost = 1;
		type = "resource";
		type2 = "job";
		faction = "neutral";
		inPlay = false;
	}
	
	public override void effect()
	{
		int tokens = 0;
		Debug.Log("Armitage");
		// Set aside 12cr
		// at the cost of 10s give 2cr.
		Runner runner = findRunner ();
		if (!inPlay)
		{
			if (runner.credits >= cost)
			{
				tokens = 12;
				timer (1);
				runner.credits -= cost;
			}
		}
		else
		{
			tokens -= 2;
			runner.credits += 2;
			if (tokens == 0)
			{
				// TODO trash the card
			}
		}
	}
}
