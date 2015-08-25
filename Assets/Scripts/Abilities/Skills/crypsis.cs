using UnityEngine;
using System.Collections;

public class crypsis : Skill
{
	public int virus;

	
	public crypsis()
	{
		name = "Crypsis";
		description = "1cr: break ice subroutine 1cr: +1 str. 10s: place 1 virus counter on cypsis. When an encounter with a piece of ice in which you used cyrpsis ends, remove 1 virus from Crypsis or trash Crypsis";
		castTime = 10;
		corp = false;
		cost = 2;
		type = "hardware";
		type2 = "icebreaker";
		faction = "neutral";
		str = 0;
		memCost = 1;
		virus = 0;

	}
	
	public override void effect()
	{
		Debug.Log("Crypsis");
		//offer choice
		//if pay == 1 they break ice subroutine
		// if 2 +1 str on Crypsis str +1
				// figure out how to let them do it multiple times
		// if time then virus++
	}
}
