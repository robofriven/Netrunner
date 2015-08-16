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
		// Set off timer
		// Is any ice rezzed?
			// yes
				//more than one?
					// yes
						// choose one to trash
					// no
						// trash only one
						// give 4cr
			// no
				//Can't use card
		Debug.Log ("Security Subcontract");
	}
}