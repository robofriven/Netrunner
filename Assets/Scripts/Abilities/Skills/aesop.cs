using UnityEngine;
using System.Collections;

public class aesop : Skill {

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
	}
	
	public override void effect()
	{
		Debug.Log("Went to the pawn shop");
		// Figure out "turn start" 30s???
		// "discard" an installed skill
		// gain 3cr.
	}
}