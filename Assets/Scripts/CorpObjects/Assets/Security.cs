using UnityEngine;
using System.Collections;

public class Security : Asset 
{
	void Start()
	{
		name = "Security Subcontract";
		type = "Asset";
		type2 = "Transaction";
		description = "Trash a rezzed piece of ice, gain 4cr";
		
	}
	
	public void effect()
	{
		print("Popup and all that telling to click on a rezzed piece of ice");
		EventHandler.waitForClick();
		EventHandler.CLICKRECEIVED += doThings;
	}

	public void doThings(Vector2 clicked)
	{
		print("Yeah, this is a placeholder for Security Subcontract");
		// check to make sure that clicked was rezzed piece of ice
			//yes
				// destroy(ice)
				// corp.credits += 4
	}
}
