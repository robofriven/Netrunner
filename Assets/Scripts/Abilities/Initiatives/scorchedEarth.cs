using UnityEngine;
using System.Collections;

public class scorchedEarth : Initiative
{
	
	public scorchedEarth()
	{
		name = "Scorched Earth";
		cost = 3;
		description = "Play only if the runner is tagged: Do 4 meat damage";
		type = "Operation";
		type2 = "Black Ops";
		kind = "Weyland";
		influence = 4;
	}
	
	public override void effect()
	{
		Debug.Log ("Scorched Earth");
		Runner runner = findRunner();
		if (runner.tags > 0)
		{
			runner.health.takeDamage("meat", 3);
		}
	}
}