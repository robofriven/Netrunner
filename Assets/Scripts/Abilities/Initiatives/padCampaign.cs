using UnityEngine;
using System.Collections;

public class padCampaign : Initiative
{
	
	public padCampaign()
	{
		name = "PAD Campaign";
		description = "Gain 1cr every 30s";
		rezCost = 2;
		type = "Asset";
		type2 = "Advertisement"; 
		kind = "Neutral";
	}
	
	public override void effect()
	{
		Vector3 position = new Vector3(-65, 5, 5);
		GameObject fw = PhotonNetwork.Instantiate ("PAD Campaign", position , Quaternion.identity, 0);
	}
}