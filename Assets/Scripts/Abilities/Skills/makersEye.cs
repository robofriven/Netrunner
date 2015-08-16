using UnityEngine;
using System.Collections;

public class makersEye : Skill {

	public makersEye() 
	{
		name = "The Maker's Eye";
		description = "Make a run on R&D, if successful, access 2 additional cards from R&D";
		castTime = 10;
		corp = false;
		cost = 2;
		type = "event";
		type2 = "run";
		faction = "shaper";
		influence = 2;
	}
	
	public override void effect()
	{
		Debug.Log("Eye is made");
	}
}
