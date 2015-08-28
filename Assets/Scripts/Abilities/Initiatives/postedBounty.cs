using UnityEngine;
using System.Collections;

public class postedBounty : Initiative
{
	
	// Use this for initialization
	public postedBounty() 
	{
		name = "Posted Bounty";
		description = "When Scored, you may forfeit it to give the runner 1 tag and gain one bad publicity";
		type = "Agenda";
		type2 = "Security";
		kind = "Weyland";
		influence = -1;
		advancement = 3;
		agendaPts = 1;
	}
	
	public override void effect ()
	{
		Vector3 position = new Vector3(-65, 5, 5);
		GameObject fw = PhotonNetwork.Instantiate ("Posted Bounty", position , Quaternion.identity, 0);
	}
}
