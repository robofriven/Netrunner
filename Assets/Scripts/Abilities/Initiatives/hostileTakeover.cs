using UnityEngine;
using System.Collections;

public class hostileTakeover : Initiative
{

	// Use this for initialization
	public hostileTakeover () 
	{
		name = "Hostile Takeover";
		description = "When you score Hostile Takeover, gain 7cr and gain 1 bad publicity";
		type = "Agenda";
		type2 = "Expansion";
		kind = "Weyland";
		influence = -1;
		advancement = 2;
		agendaPts = 2;
	}

	public override void effect ()
	{
		// When scored
		// Give 7cr
		Debug.Log ("Hostile Takeover was clicked");
	}
}
