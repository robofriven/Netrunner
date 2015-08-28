using UnityEngine;
using System.Collections;

public class Hostile : Agenda 
{
	void Start()
	{
		name = "Hostile Takeover";
		description = "When you score Hostile Takeover, gain 7cr and gain 1 bad publicity";
		type = "Agenda";
		type2 = "Expansion";
		points = 1;
		completionCost = 2;
	}

	public override void activate()
	{
		corp.agendaPts += points;
		corp.credits += 7;
		corp.badPub ++;
	}
	
}
