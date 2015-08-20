using UnityEngine;
using System.Collections;

public class Posted : Agenda 
{
	Runner runner;
	void Start()
	{
		name = "Posted Bounty";
		description = "When Scored, you may forfeit it to give the runner 1 tag and gain one bad publicity";
		type = "Agenda";
		type2 = "Security";
		points = 1;
		completionCost = 3;
	}
	
	public override void activate()
	{
		Debug.Log ("Give option to forfiet the agenda pts");

			//If yes
				runner = findRunner ();
				//runner.tag ++
				//corp.badPub ++;
			// if no
				//corp.agendaPts += points
				// corp.scored.Add(this)
				// Destroy(this)
	}
}
