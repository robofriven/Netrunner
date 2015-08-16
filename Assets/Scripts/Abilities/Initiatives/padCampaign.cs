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
		Debug.Log ("PAD  Campaign... figure out what a turn is!");
		// While the card is rezzed it will get 1 cr every 3 timers, need to remember to
		// set rezzed to false when trashing a card to turn that off.
		if (rezzed)
		{
			while (rezzed)
			{
				timer(3);
				Corp corp = findCorp();
				corp.credits ++;
			}
		}
		else
		{
			rezInit();
		}
	}
}