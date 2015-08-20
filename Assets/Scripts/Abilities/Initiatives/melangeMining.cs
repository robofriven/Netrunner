using UnityEngine;
using System.Collections;

public class melangeMining : Initiative
{
	
	public melangeMining()
	{
		name = "Melange Mining Corp.";
		description = "three clicks: Gain 7cr";
		rezCost = 1;
		type = "Asset";
		type2 = null;
		kind = "Neutral";
		trashCost = 1;
	}
	
	public override void effect()
	{
		Vector3 position = new Vector3(-65, 5, 5);
		GameObject fw = PhotonNetwork.Instantiate ("Melange Mining Corp", position , Quaternion.identity, 0);
	}
}