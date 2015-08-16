using UnityEngine;
using System.Collections;

public class personalTouch : Skill
{

	public personalTouch() 
	{
		name = "The Personal Touch";
		description = "Install The Personal Touch only on an icebreaker.  Host icebreaker has +1 str";
		castTime = 10;
		corp = false;
		cost = 2;
		type = "hardware";
		type2 = "mod";
		faction = "shaper";
		influence = 2;
	}
	
	public override void effect()
	{
		Debug.Log("The Personal Touch");
		//Give target Icebreaker +1 str.
	}
}
