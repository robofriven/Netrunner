using UnityEngine;
using System.Collections;

public class kate : Runner 
{
	void Start () 
	{
		name = "Kate Mac";
		title = "Digital Tinker";
		description = "Lower the install cost of the first program or piece of hardware you install each turn by 1.";
		type = "shaper";
		links = 1;
		identity = "Natural";
		maxSkills = 45;
		externalSkills = 15;
	}

	public override void effect()
	{
		//Find out how to make this work
		//"turn start" (every 30s???)
		//First program/hardware -1 cost.
		Debug.Log ("Next cost will be 1 less");
	}

}
