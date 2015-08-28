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
		Vector3 position = new Vector3(-65, 5, 5);
		GameObject fw = PhotonNetwork.Instantiate ("Private Security", position , Quaternion.identity, 0);

	}
}