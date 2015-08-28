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
		agendaPts = 1;
	}

	public override void effect ()
	{
		Vector3 position = new Vector3(-65, 5, 5);
		GameObject fw = PhotonNetwork.Instantiate ("Hostile Takeover", position , Quaternion.identity, 0);
	}
}
