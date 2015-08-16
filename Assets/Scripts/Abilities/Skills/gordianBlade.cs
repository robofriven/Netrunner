using UnityEngine;
using System.Collections;

public class gordianBlade : Skill {

	public gordianBlade()
	{
		name = "Gordian Blade";
		description = "1cr: Break code gate subroutine. 1cr: +1 str for the remainder of this run.";
		castTime = 10;
		corp = false;
		cost = 4;
		type = "program";
		type2 = "icebreaker";
		str = 2;
		memCost = 1;
		faction = "shaper";
		influence = 3;
	}
	
	public override void effect(int pay)
	{
		Debug.Log("The Personal Touch");
		// if pay != 0 give option
		// do thing
	}
}