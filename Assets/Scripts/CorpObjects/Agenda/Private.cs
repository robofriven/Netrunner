using UnityEngine;
using System.Collections;

public class Private : Agenda 
{
	void Start()
	{
		name = "Private Security Force";
		description = "If the runner is tagged, Private Security force gains '10s do 1 meat damage' when scored";
		type = "Agenda";
		type2 = "Security";
		points = 2;
		completionCost = 4;
	}
	
	public override void activate()
	{
		Debug.Log ("Private Security Force...Not really sure how to handle this one yet.");

		corp.agendaPts += points;

		// Move the card to a different part of the screen (where all scored cards go or not?)

		// Give this the ability (seperate prefab???) something like

		// if (runner.tags > 0) {runner.health.TakeDamage("meat", 1);}

		
	}
}
