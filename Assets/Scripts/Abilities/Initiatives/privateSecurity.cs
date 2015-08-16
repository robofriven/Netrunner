using UnityEngine;
using System.Collections;

public class privateSecurity : Initiative
{

	bool scored;
	
	public privateSecurity()
	{
		name = "Private Security Force";
		description = "If the runner is tagged, Private Security force gains '10s do 1 meat damage'";
		type = "Agenda";
		type2 = "Security";
		kind = "Neutral";
		advancement = 4; 
		agendaPts = 2;
		scored = false;
	}
	
	public override void effect()
	{
		// TODO Move this card to scored area after scoring (or someplace else clickable)

		Debug.Log ("Private Security Force");
		Runner runner = findRunner();
		if (scored)
		{
			if (runner.tags > 0)
			{
				runner.health.takeDamage("meat", 1);
			}
		}
	}
}