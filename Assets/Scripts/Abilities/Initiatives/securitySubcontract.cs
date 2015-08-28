using UnityEngine;
using System.Collections;

public class securitySubcontract : Initiative
{
	
	// Use this for initialization
	public securitySubcontract() 
	{
		name = "Security Subcontract";
		cost = 0;
		description = "TIMER, trash a rezzed piece of ice, gain 4cr";
		rezCost = 0;
		type = "Asset";
		type2 = "Transaction";
		kind = "Weyland";
		influence = 1;
		trashCost = 3;
	}
	
	public override void effect ()
	{
		Vector3 position = new Vector3(-65, 5, 5);
		GameObject fw = PhotonNetwork.Instantiate ("Security Subcontract", position , Quaternion.identity, 0);
	}
}