using UnityEngine;
using System.Collections;

public class accessGlobalsec : Skill
{
	
	public accessGlobalsec() 
	{
		name = "Access to Globalsec";
		description = "+1 Link";
		castTime = 10;
		corp = false;
		cost = 1;
		type = "resource";
		type2 = "link";
		faction = "neutral";
	}
	
	public override void effect()
	{
		Debug.Log("Access to Globalsec");
		timer (1);
		Runner runner = findRunner ();
		if (runner.credits >= cost)
		{
			runner.links ++;
			runner.credits --;
		}
	}
}

