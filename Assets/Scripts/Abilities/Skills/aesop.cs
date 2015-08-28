using UnityEngine;
using System.Collections;

public class aesop : Skill 
{
	public float turnLength;
	public float corpHeadstart;
	public float lastUsed;

	public aesop()
	{
		name = "Aesop's Pawnshop";
		description = "When your turn begins, you may trash another installed skill to gain 3cr";
		castTime = 10;
		corp = false;
		cost = 1;
		type = "resource";
		type2 = "connection";
		faction = "shaper";
		influence = 2;

		turnLength = 30f;
		corpHeadstart = 10f;
		lastUsed = 0;
	}
	
	public override void effect()
	{
		Debug.Log("Went to the pawn shop");

		if (gameController.timeSinceStart - lastUsed >= turnLength)
		{
			Debug.Log("Click on an installed program");
			//Have runner pick an installed program
				//trash program
				// runner.credits += 3
		}
		
		// Figure out "turn start" 30s???
		// "discard" an installed skill
		// gain 3cr.
	}
}